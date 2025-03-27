using System.Collections.Generic;
using System.Linq;
using CoreWCF;
using Hotels.Models;

namespace Hotels.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] // Указываем CoreWCF
    public class HotelService : IHotelService
    {
        private readonly HotelsContext _context;

        public HotelService(HotelsContext context)
        {
            _context = context;
        }

        public List<Hotel> GetHotels()
        {
            return _context.Hotels.ToList();
        }

        public Hotel GetHotelById(int id)
        {
            return _context.Hotels.Find(id);
        }

        public void AddHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
        }

        public void UpdateHotel(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            _context.SaveChanges();
        }

        public void DeleteHotel(int id)
        {
            var hotel = _context.Hotels.Find(id);
            if (hotel != null)
            {
                _context.Hotels.Remove(hotel);
                _context.SaveChanges();
            }
        }
    }
}
