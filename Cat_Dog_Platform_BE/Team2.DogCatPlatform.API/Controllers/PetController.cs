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
    public class PetController : Controller
    {
        private readonly IPetService _petService;
        private readonly IMapper _mapper;

        public PetController(IPetService petService, IMapper mapper)
        {
            _petService = petService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pet>))]
        public IActionResult GetPet()
        {
            var pet = _mapper.Map<List<PetDTO>>(_petService.GetPets());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pet);

        }

        [HttpGet("{petId}")]
        [ProducesResponseType(200, Type = typeof(Pet))]
        [ProducesResponseType(400)]
        public IActionResult GetPetbyId(string petId)
        {

            if (!_petService.PestExists(petId))
                return NotFound();

            var pet = _mapper.Map<PetDTO>(_petService.GetPetbyId(petId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pet);

        }


    }
}
