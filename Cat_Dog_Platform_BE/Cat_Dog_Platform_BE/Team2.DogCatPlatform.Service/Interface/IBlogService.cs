using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Model;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service.Interface
{
    public interface IBlogService
    {

        ICollection<Blog> GetBlog();

        Blog GetBlogById(String id);

        Blog GetBlogbyTitle(String Title);

        bool BlogExists(string BlogId);

    }
}
