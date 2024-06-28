using Microsoft.EntityFrameworkCore;
using oteldeneme.Data;
using oteldeneme.Interfaces;
using oteldeneme.Models;


namespace oteldeneme.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly HotelContext _context;

        public HotelRepository(HotelContext context)
        {
            _context = context;
        }

        public Hotel GetById(int id)
        {
            return _context.Hotels.Find(id);
        }

        public IEnumerable<Hotel> GetAll()
        {
            return _context.Hotels.ToList();
        }

        public void Add(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
        }

        public void Update(Hotel entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Hotel hotel = _context.Hotels.Find(id);
            if (hotel != null)
            {
                _context.Hotels.Remove(hotel);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
