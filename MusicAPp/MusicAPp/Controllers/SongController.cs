using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetSong()
        {
            var song = _songRepository.GetSong("happy");
            return Ok(song);
        }
        [HttpPost]
        public IActionResult AddSong(Song song)
        {
            _songRepository.AddSong(song);
            return Ok("Success");
        }
    }
}
