using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Model;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service.Interface
{
    public interface IPostService
    {
        ICollection<Post> GetPosts();

        Post GetPost(String id);

       bool PostExists (String id);
    }
}
