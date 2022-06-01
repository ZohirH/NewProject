using Api.Data;
using Api.Data.Entity;

namespace Api.Service
{
    public class TrackService
    {
        private DataContext _context;

        public TrackService(DataContext context)
        {
            _context = context;
        }
        public int InsertTrack(TrackModel track)
        {
            var t = new Track()
            {
               
                TrackName = track.TrackName
            };
            _context.Tracks.Add(t);
            return _context.SaveChanges();
           
        }
    }
}
