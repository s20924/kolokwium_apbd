using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using przedKolokwium1.Services;
using System;
using System.Threading.Tasks;

namespace przedKolokwium1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IDbService _dbService;

        public AlbumController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{idAlbum}")]
        public async Task<IActionResult> GetAlbum(int idAlbum)
        {
            Console.WriteLine(idAlbum);

            if (!await _dbService.CheckIfExists(idAlbum)) return NotFound("Klient o podanym id nie istnieje");

            var album = await _dbService.GetAlbum(idAlbum);
            if (album == null) return NotFound("Problem");
            else return Ok(album);
        }
    }
}
