using myIMDb.Data.Models;
using myIMDb.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Data.Services
{
    public class ProducerService
    {
        private AppDbContext _context;
        public ProducerService(AppDbContext context)
        {
            _context = context;
        }

        public void AddProducer(ProducerVM producer)
        {
            var _producer = new Producer()
            {
                Name = producer.Name,
                Sex = producer.Sex,
                DOB = producer.DOB,
                Bio = producer.Bio
            };

            _context.Producer.Add(_producer);
            _context.SaveChanges();

        }
        public List<Producer> GetAllProducers()
        {
            return _context.Producer.ToList();
        }

        public void DeleteProducerById(int producerId)
        {
            var _producer = _context.Producer.FirstOrDefault(n => n.Id == producerId);
            if (_producer != null)
            {
                _context.Producer.Remove(_producer);
                _context.SaveChanges();
            }
        }
    }
}
