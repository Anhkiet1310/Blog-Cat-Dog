using Cat_Dog_Platform_PE.Entity;
using Repository;

namespace Cat_Dog_Platform_PE.Repository
{
    public class BlogCommentRepository : Repository<BlogComment>
    {
        public BlogCommentRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
