using Microsoft.EntityFrameworkCore;
using przedKolokwium1.Models;
using przedKolokwium1.Models.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace przedKolokwium1.Services
{
    public class DbService : IDbService
    {
        private readonly MainDbContext _mainDbContext;
        public DbService(MainDbContext dbContext)
        {
            _mainDbContext = dbContext;
        }

        public async Task<bool> CheckIfExists(int idAlbum)
        {
            var album = await _mainDbContext.Albums.Where(e => e.IdAlbum == idAlbum).FirstOrDefaultAsync();
            if (album is null) return false;
            return true;
        }

        public async Task<IEnumerable<SomeSortOfAlbum>> GetAlbum(int idAlbum)
        {
            return await _mainDbContext.Albums
                .Where(e => e.IdAlbum == idAlbum)
                .Include(e => e.Tracks)
                .Select(e => new SomeSortOfAlbum
                {
                    AlbumName = e.AlbumName,
                    PublishDate = e.PublishDate,
                    TrackList = e.Tracks.Select(e => e.TrackName)
                })
                .ToListAsync();
        }
    }
}
