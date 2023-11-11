using Cat_Dog_Platform_BE.Entity;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Repository
{
    public class BlogCommentRepository : Repository<BlogComment>
    {
        public BlogCommentRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
