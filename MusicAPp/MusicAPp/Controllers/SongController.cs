using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicAPp.Dtos;
using MusicAPp.Interfaces;
using MusicAPp.Models;

namespace MusicAPp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : Controller
    {
        private readonly ISongRepository _songRepository;
        private readonly IMapper _mapper;
        public SongController(ISongRepository songRepository, IMapper mapper)
        {
            _songRepository = songRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetSong(string title)
        {
            var song = _songRepository.GetSong(title);
            return Ok(song);
        }
        [HttpPost]
        public IActionResult AddSong(SongDto song)
        {
            _songRepository.AddSong(_mapper.Map<Song>(song));
            return Ok("Success");
        }
    }
}
