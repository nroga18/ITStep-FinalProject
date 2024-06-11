using MusicAPp.Data;
using MusicAPp.Interfaces;
using MusicAPp.Models;

namespace MusicAPp.Repositories
{
    public class SongRepository : ISongRepository
    {
        private readonly MusicDbContext _context;
        public SongRepository(MusicDbContext context)
        {
            _context = context;
        }
        public void AddSong(Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
        }

        public void DeleteSong(int id)
        {
            var song = _context.Songs.FirstOrDefault(s => s.Id == id);
            if (song != null)
            {
                _context.Songs.Remove(song);
            }
            _context.SaveChanges();
        }

        public Album GetAlbum(int id)
        {
            var song = _context.Songs.FirstOrDefault(s => s.Id == id);
            if (song != null)
            {
                return song.Album;
            }
            return null;
        }

        public ICollection<Artist> GetArtists(int id)
        {
            var song = _context.Songs.FirstOrDefault(s => s.Id == id);
            if (song != null)
            {
                return song.SongArtists.Select(x => x.Artist).ToList();
            }
            return null;
        }

        public Song GetSong(string title)
        {
            return _context.Songs.FirstOrDefault(x => x.Title == title);
        }

        public ICollection<Song> GetSongs()
        {
            return _context.Songs.ToList();
        }

        public void UpdateSong(Song song)
        {
            _context.Songs.Update(song);
            _context.SaveChanges();
        }
    }
}
