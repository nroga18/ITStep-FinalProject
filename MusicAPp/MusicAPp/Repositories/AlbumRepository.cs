using MusicAPp.Data;
using MusicAPp.Interfaces;
using MusicAPp.Models;

namespace MusicAPp.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly MusicDbContext _context;
        public AlbumRepository(MusicDbContext context)
        {
            _context = context;
        }
        public void AddAlbum(Album album)
        {
            _context.Albums.Add(album);
            _context.SaveChanges();
        }

        public void DeleteAlbum(int id)
        {
            var album = _context.Albums.FirstOrDefault(a => a.Id == id);
            if (album != null)
            {
                _context.Albums.Remove(album);
            }
            _context.SaveChanges();
        }

        public Album GetAlbum(int id)
        {
            return _context.Albums.FirstOrDefault(album => album.Id == id);
        }
    }
}
