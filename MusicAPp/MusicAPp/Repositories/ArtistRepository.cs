using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using MusicAPp.Data;
using MusicAPp.Interfaces;
using MusicAPp.Models;

namespace MusicAPp.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly MusicDbContext _musicDbContext;
        public ArtistRepository(MusicDbContext musicDbContext)
        {
            _musicDbContext = musicDbContext;
        }

        public void AddArtist(Artist artist)
        {
            _musicDbContext.Artists.Add(artist);
            _musicDbContext.SaveChanges();
        }

        public void DeleteArtist(int id)
        {
            var artist = _musicDbContext.Artists.FirstOrDefault(a => a.Id == id);
            if (artist != null)
            {
                _musicDbContext.Artists.Remove(artist);
                _musicDbContext.SaveChanges();
            }

        }

        public Artist GetArtist(int id)
        {
            var artist = _musicDbContext.Artists.FirstOrDefault(a => a.Id == id);
            if (artist != null)
            {
                return artist;
            }
            return null;
        }

        public void UpdateArtist(Artist artist)
        {
            _musicDbContext.Artists.Update(artist);
            _musicDbContext.SaveChanges();
        }
    }
}
