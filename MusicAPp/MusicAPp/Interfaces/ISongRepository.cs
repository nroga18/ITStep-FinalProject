using MusicAPp.Models;

namespace MusicAPp.Interfaces
{
    public interface ISongRepository
    {
        ICollection<Song> GetSongs();
        Album GetAlbum(int id);
        ICollection<Artist> GetArtists(int id);   
        Song GetSong(string title);

        void AddSong(Song song);
        void UpdateSong(Song song);
        void DeleteSong(int id);

    }
}
