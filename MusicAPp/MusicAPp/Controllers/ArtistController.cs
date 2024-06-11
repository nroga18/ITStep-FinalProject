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
    public class ArtistController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IArtistRepository _repository;
        public ArtistController(IMapper mapper, IArtistRepository artistRepository)
        {
            _mapper = mapper;
            _repository = artistRepository;
        }
        [HttpGet]
        public IActionResult GetArtist(int id)
        {
            var artist = _repository.GetArtist(id);
            return Ok(artist);
        }
        [HttpPost]
        public IActionResult AddArtist(ArtistDto artist)
        {
            _repository.AddArtist(_mapper.Map<Artist>(artist));
            return Ok("Success");
        }
    }
}
