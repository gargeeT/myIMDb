using myIMDb.Data.Models;
using myIMDb.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Data.Services
{
    public class MovieService
    {
        private AppDbContext _context;
        public MovieService(AppDbContext context)
        {
            _context = context;
        }

        public void AddMovie(MovieVM movie)
        {
            var _movie = new Movie()
            {
                Name = movie.Name,
                YearOfRelease = movie.YearOfRelease,
                Plot = movie.Plot,
                Poster = movie.Poster,
                ProducerId = movie.producer_id,

            };

            _context.Movie.Add(_movie);
            _context.SaveChanges();

            
        }
        public void AddMovieWithActors(MovieVM movie)
        {
            var _movie = new Movie()
            {
                Name = movie.Name,
                YearOfRelease = movie.YearOfRelease,
                Plot = movie.Plot,
                Poster = movie.Poster,
                ProducerId = movie.producer_id,

            };
            
            _context.Movie.Add(_movie);
            _context.SaveChanges();

            foreach (var id in movie.ActorIds)
            {
                var _movie_actor = new MovieCast()
                {
                    ActorId = id,
                    MovieId = _movie.Id
                };
                _context.MovieCast.Add(_movie_actor);
                _context.SaveChanges();
            }
        }

        public List<MovieWithActorsVM> GetAllMovies()
        {
            // return _context.Movie.ToList();
            
            var _movieWithActors = _context.Movie.Select(movie => new MovieWithActorsVM()
            {
                Id= movie.Id,
                Name = movie.Name,
                YearOfRelease = movie.YearOfRelease,
                Plot = movie.Plot,
                Poster = movie.Poster,
                ProducerName = movie.Producer.Name,
                ActorNames = movie.MovieCasts.Select(n => n.Actor.Name).ToList()

            }).ToList();

            return _movieWithActors;
        }

        public MovieWithActorsVM GetMovieById(int movieId)
        {

            //return _context.Movie.FirstOrDefault(n=>n.Id==movieId);

            var _movieWithActors = _context.Movie.Where(n => n.Id == movieId).Select(movie => new MovieWithActorsVM()
            {
                Id=movieId,
                Name = movie.Name,
                YearOfRelease = movie.YearOfRelease,
                Plot = movie.Plot,
                Poster = movie.Poster,
                ProducerName = movie.Producer.Name,
                ActorNames = movie.MovieCasts.Select(n => n.Actor.Name).ToList()
                
            }).FirstOrDefault();

            return _movieWithActors;
        }

        public Movie UpdateMovieById(int movieId, MovieVM movie)
        {
            var _movie = _context.Movie.FirstOrDefault(n => n.Id == movieId);
           // var _actor = _context.MovieCast.Select(n => n.MovieId == movieId).ToList();
            if (_movie != null)
            {
                _movie.Name = movie.Name;
                _movie.YearOfRelease = movie.YearOfRelease;
                _movie.Plot = movie.Plot;
                _movie.Poster = movie.Poster;
                _movie.ProducerId = movie.producer_id;
               
                _context.SaveChanges();
            }

            
            //Remove existing actors
            var existingActors = _context.MovieCast.Where(n => n.MovieId == movieId).ToList();
            _context.MovieCast.RemoveRange(existingActors);

            _context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var actorId in movie.ActorIds)
            {
                var newActorMovie = new MovieCast()
                {
                    MovieId = movieId,
                    ActorId = actorId
                };
                _context.MovieCast.AddAsync(newActorMovie);
            }
            _context.SaveChangesAsync();
            return _movie;
        }
        

        public void DeleteMovieById(int movieId)
        {
            var existingActors = _context.MovieCast.Where(n => n.MovieId == movieId).ToList();
            _context.MovieCast.RemoveRange(existingActors);

             _context.SaveChangesAsync();

            var _movie = _context.Movie.FirstOrDefault(n => n.Id == movieId);
            if (_movie != null)
            {

                 _context.Movie.Remove(_movie);
                 _context.SaveChanges();

            }
           

        }
    }

    /*public Movie UpdateMovieById(int movieId, MovieVM movie)
        {
            var _movie = _context.Movie.FirstOrDefault(n => n.Id == movieId);
            if (_movie != null)
            {
                _movie.Name = movie.Name;
                _movie.YearOfRelease = movie.YearOfRelease;
                _movie.Plot = movie.Plot;
                _movie.Poster = movie.Poster;
                _movie.ProducerId = movie.producer_id;
                
                _context.SaveChanges();
            }

            return _movie;
        }*/
}
