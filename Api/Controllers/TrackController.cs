using Api.Data.Entity;
using Api.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private TrackService _TrackService;
        public TrackController(TrackService trackService)
        {
            _TrackService = trackService;
        }
        [HttpPost("InsertTrack")]
        public int InsertTrack(TrackModel track)
        {
            return _TrackService.InsertTrack(track);
        }
    }
}
