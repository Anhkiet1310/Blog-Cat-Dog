using AutoMapper;
using Cat_Dog_Platform_BE.DTO;
using Cat_Dog_Platform_BE.DTO.requestDTO;
using Cat_Dog_Platform_BE.Entity;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.DTO;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.DTO.requestDTO;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Helper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Role, RoleDTO>().ReverseMap();
            CreateMap<Tag, TagDTO>().ReverseMap();
            CreateMap<Account, AccountDTO>().ReverseMap();
            CreateMap<PetType, PetTypeDTO>().ReverseMap();
            CreateMap<BlogType, BlogTypeDTO>().ReverseMap();
            CreateMap<BlogComment, BlogCommentDTO>().ReverseMap();
            CreateMap<Blog, BlogDTO>().ReverseMap();
            CreateMap<PostComment, PostCommentDTO>().ReverseMap();
            CreateMap<PostLike, PostLikeDTO>().ReverseMap();
            CreateMap<Post, PostDTO>().ReverseMap();
            CreateMap<TradePost, TradeDTO>().ReverseMap();
            CreateMap<TradeComment, TradeCommentDTO>().ReverseMap();
            //
            CreateMap<Account, SignInDTO>().ReverseMap();
            CreateMap<Account, SignUpDTO>().ReverseMap();
            CreateMap<Post, CreatePostDTO>().ReverseMap();
            CreateMap<Blog, createBlogDTO>().ReverseMap();
        }
    }
}

