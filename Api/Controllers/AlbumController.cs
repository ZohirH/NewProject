using Api.Data.Entity;
using Api.Service;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private AlbumService _albumService;
        public AlbumController(AlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet("GetAlbums")]
        public async Task<List<Album>> GetAlbums()
        {
            return await _albumService.GetAlbums();
        }

        [HttpPost("InsertAlbum")]
        public int InsertAlbum (AlbumModel album)
        {
           return _albumService.InsertAlbum(album);
        }
    }
}
