using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicAPp.Dtos;
using MusicAPp.Interfaces;
using MusicAPp.Models;
using System;

namespace MusicAPp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAlbumRepository _albumRepository;
        public AlbumController(IMapper mapper, IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAlbum(int id)
        {
            var album = _albumRepository.GetAlbum(id);
            return Ok(album);
        }
        [HttpPost]
        public IActionResult AddAlbum(AlbumDto album)
        {
            if (album == null)
            {
                return BadRequest();
            }
            _albumRepository.AddAlbum(_mapper.Map<Album>(album));
            return Ok("success");
        }
    }
}
