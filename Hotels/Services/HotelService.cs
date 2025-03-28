using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotels.Models;
using Microsoft.EntityFrameworkCore;

public class HotelService : IHotelService
{
    private readonly HotelsContext _context;

    public HotelService(HotelsContext context)
    {
        _context = context;
    }

    public async Task<List<Hotel>> GetHotelsAsync()
    {
        return await _context.Hotels.ToListAsync();
    }

    public async Task<Hotel> GetHotelByIdAsync(int id)
    {
        return await _context.Hotels.FindAsync(id);
    }

    public async Task<bool> CreateHotelAsync(Hotel hotel)
    {
        _context.Hotels.Add(hotel);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateHotelAsync(Hotel hotel)
    {
        _context.Hotels.Update(hotel);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteHotelAsync(int id)
    {
        var hotel = await _context.Hotels.FindAsync(id);
        if (hotel == null) return false;

        _context.Hotels.Remove(hotel);
        return await _context.SaveChangesAsync() > 0;
    }
}
