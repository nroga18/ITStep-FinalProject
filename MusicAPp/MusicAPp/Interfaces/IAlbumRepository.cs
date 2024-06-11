using MusicAPp.Models;

namespace MusicAPp.Interfaces
{
    public interface IAlbumRepository
    {
        Album GetAlbum(int id);
        void AddAlbum(Album album);
        void DeleteAlbum(int id);
    }
}
