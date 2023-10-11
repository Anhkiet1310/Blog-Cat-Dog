using AutoMapper;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.DTO;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Model;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pet, PetDTO>();

            CreateMap<Blog, BlogDTO>();

            CreateMap<Post, PostDTO>();
        }
    }
}
