using przedKolokwium1.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace przedKolokwium1.Services
{
    public interface IDbService
    {
        Task<IEnumerable<SomeSortOfAlbum>> GetAlbum(int idAlbum);
        Task<bool> CheckIfExists(int idAlbum);
    }
}
