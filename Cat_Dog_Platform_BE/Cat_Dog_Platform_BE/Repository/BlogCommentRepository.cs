using Cat_Dog_Platform_BE.Entity;
using Repository;

namespace Cat_Dog_Platform_BE.Repository
{
    public class BlogCommentRepository : Repository<BlogComment>
    {
        public BlogCommentRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
