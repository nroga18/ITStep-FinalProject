using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicAPp.Dtos;
using MusicAPp.Models;

namespace MusicAPp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()    
        {
            CreateMap<Song, SongDto>();
            CreateMap<SongDto, Song>();
            CreateMap<Album, AlbumDto>();
            CreateMap<AlbumDto, Album>();
            CreateMap<Artist, ArtistDto>();
            CreateMap<AlbumDto, Album>();
        }
    }
}
