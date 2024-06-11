using MusicAPp.Models;

namespace MusicAPp.Interfaces
{
    public interface IArtistRepository
    {
        void AddArtist(Artist artist);
        Artist GetArtist(int id);
        void UpdateArtist(Artist artist);
        void DeleteArtist(int id);

    }
}
