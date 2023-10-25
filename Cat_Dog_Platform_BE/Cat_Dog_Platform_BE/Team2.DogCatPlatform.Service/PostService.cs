using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Model;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service.Interface;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service
{
    public class PostService : IPostService

    {
        private SwpProjectContext _context = new SwpProjectContext();


        public Post GetPost(string id)
        {
            return _context.Posts.Where(p => p.IdPosts == id).FirstOrDefault();
        }

        public ICollection<Post> GetPosts()
        {
            return _context.Posts.OrderBy(p => p.IdPosts).ToList();
        }

        public bool PostExists(string postId)
        {
            return _context.Posts.Any(p => p.IdPosts.Contains(postId));
        }
    }
}
