using Api.Data;
using Api.Data.Entity;

namespace Api.Service
{
    public class AlbumService
    {
        private readonly DataContext _cont;
        public AlbumService(DataContext context)
        {
            _cont = context;
        }

         public async Task<List<Album>> GetAlbums()
        {
            var albums = _cont.Albums.ToList();
            return albums;

        }

        public int InsertAlbum (AlbumModel model)
        {
            var album = new Album()
            {
                AlbumId = model.AlbumId,
                Title = model.Title,
                 ArtistId= model.ArtistId
            };
            var albums = _cont.Albums.Add(album);
            return _cont.SaveChanges();
        }
    }
}
