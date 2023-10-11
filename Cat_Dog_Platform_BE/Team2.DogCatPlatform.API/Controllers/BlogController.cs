using AutoMapper;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.DTO;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Model;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.API.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public BlogController(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Blog>))]

        public IActionResult GetBlog()
        {

            var blog = _mapper.Map<List<BlogDTO>>(_blogService.GetBlog());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(blog);
        }

        [HttpGet("{blogId}")]
        [ProducesResponseType(200, Type = typeof(Blog))]
        [ProducesResponseType(400)]

        public IActionResult GetBlog(string blogId)
        {

            if (!_blogService.BlogExists(blogId))
                return NotFound();

            var blog = _mapper.Map<Blog>(_blogService.GetBlogById(blogId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(blog);

        }

    }
}
