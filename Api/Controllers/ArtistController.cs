using Api.Data.Entity;
using Api.Service;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistController : ControllerBase
    {
        private ArtistService _service;

        public ArtistController(ArtistService service)
        {
            _service = service;
        }
        [HttpGet("GetArtists")]
        public async Task<List<Artist>> GetArtists()
        {
            return await _service.GetArtists();
        }

        [HttpGet("GetJoinArtists")]
        public List<ArtistJoin> GetJoinArtists()
        {
            return _service.GetJoinArtists();
        }


        [HttpPost("InsertArtist")]
        public int InsertArtist(ArtistModel artist)
        {
            return _service.InsertArtist(artist); 
        }
    }
}
