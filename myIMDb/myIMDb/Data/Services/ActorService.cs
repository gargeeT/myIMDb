using myIMDb.Data.Models;
using myIMDb.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Data.Services
{
    public class ActorService
    {
        private AppDbContext _context;
        public ActorService(AppDbContext context)
        {
            _context = context;
        }

        public void AddActor(ActorVM actor)
        {
            var _actor = new Actor()
            {
                Name = actor.Name,
                Sex = actor.Sex,
                DOB = actor.DOB,
                Bio = actor.Bio
            };

            _context.Actor.Add(_actor);
            _context.SaveChanges();

        }
        public List<Actor> GetAllActors()
        {
            return _context.Actor.ToList();
        }
        public void DeleteActorById(int actorId)
        {
            var _actor = _context.Actor.FirstOrDefault(n => n.Id == actorId);
            if (_actor != null)
            {
                _context.Actor.Remove(_actor);
                _context.SaveChanges();
            }
        }
    }
}
