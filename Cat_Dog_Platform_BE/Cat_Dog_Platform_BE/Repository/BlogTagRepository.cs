using Cat_Dog_Platform_BE.Entity;
using Repository;

namespace Cat_Dog_Platform_BE.Repository
{
    public class BlogTagRepository : Repository<BlogTag>
    {
        public BlogTagRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
