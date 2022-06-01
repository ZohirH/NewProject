using Api.Data;
using Api.Data.Entity;
using AutoMapper;

namespace Api.Service
{
    public class ArtistService
    {
        private readonly DataContext _cont;
        private readonly IMapper _mapper;

        public ArtistService(DataContext context, IMapper mapper)
        {
            _cont = context;
            _mapper = mapper;
        }

        public async Task<List<Artist>> GetArtists()
        {
            var artists = _cont.Artists.ToList();
            return artists;

        }

        public List<ArtistJoin> GetJoinArtists()
        {
           var list =  (
           from ar in _cont.Artists
           join al in _cont.Albums on ar.ArtistId equals al.ArtistId
           select new ArtistJoin
             {
             ArtistId = al.ArtistId,
             ArtistName = ar.ArtName,
             AlbumId =al.AlbumId,
             AlbumName = al.Title
             }).ToList();
            return list;
        }

        public int InsertArtist(ArtistModel artist)
        {
            var entry = _mapper.Map<Artist>(artist);
            _cont.Artists.Add(entry);
            //var ar = new Artist()
            //{
            //    ArtistId = artist.ArtistId,
            //    ArtistName = artist.ArtistName
            //};
            //_cont.Artists.Add(ar);
            return _cont.SaveChanges();
        }
    }
}
