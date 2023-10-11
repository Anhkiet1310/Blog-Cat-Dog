using AutoMapper;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.DTO;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Model;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.API.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {

        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostController(IPostService postService, IMapper mapper)
        {

            _postService = postService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Post>))]

        public IActionResult GetPost()
        {

            var post = _mapper.Map<List<PostDTO>>(_postService.GetPosts());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(post);

        }

        [HttpGet("{postId}")]
        [ProducesResponseType(200, Type = typeof(Post))]
        [ProducesResponseType(400)]
        public IActionResult GetPetbyId(string postId)
        {

            if (!_postService.PostExists(postId))
                return NotFound();

            var post = _mapper.Map<PostDTO>(_postService.GetPost(postId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(post);

        }

    }
}
