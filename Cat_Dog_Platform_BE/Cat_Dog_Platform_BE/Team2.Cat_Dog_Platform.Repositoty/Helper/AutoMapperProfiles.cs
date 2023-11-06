using AutoMapper;
using Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Entity;
using Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Service.DTO;
using Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Service.DTO.requestDTO;

namespace Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Helper
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
            //
            CreateMap<Account, SignInDTO>().ReverseMap();
            CreateMap<Account, SignUpDTO>().ReverseMap();
            CreateMap<Post, CreatePostDTO>().ReverseMap();
            CreateMap<Blog, createBlogDTO>().ReverseMap();
        }
    }
}

