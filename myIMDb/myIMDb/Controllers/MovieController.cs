using Microsoft.AspNetCore.Mvc;
using myIMDb.Data.Services;
using myIMDb.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieService _movieService;

    

        public MovieController(MovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpPost]
        public IActionResult AddMovie([FromBody] MovieVM movie)
        {
           _movieService.AddMovie(movie);
            return Ok();
        }


        [HttpPost("add-movie-with-actors")]
        public IActionResult AddMovieWithActors([FromBody] MovieVM movie)
        {
            _movieService.AddMovieWithActors(movie);
            return Ok();
        }

        [HttpGet("get-all-movies")]
        public IActionResult GetAllMovies()
        {
            var allMovies = _movieService.GetAllMovies();
            return Ok(allMovies);
        }

        [HttpGet("get-movie-by-id/{id}")]
        public IActionResult GeMovieById(int id)
        {
            var movie = _movieService.GetMovieById(id);
            return Ok(movie);
        }

        [HttpPut("update-movie-by-id/{id}")]
        public IActionResult UpdateMovieById(int id, [FromBody] MovieVM movie)
        {
            var updatedMovie = _movieService.UpdateMovieById(id, movie);
            return Ok(updatedMovie);
        }

        [HttpDelete("delete-movie-by-id/{id}")]
        public IActionResult DeleteMovieById(int id)
        {
            _movieService.DeleteMovieById(id);
            return Ok();
        }

       
    }
}
