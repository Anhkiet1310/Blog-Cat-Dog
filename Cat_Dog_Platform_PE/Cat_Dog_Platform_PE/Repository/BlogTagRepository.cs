using Cat_Dog_Platform_PE.Entity;
using Repository;

namespace Cat_Dog_Platform_PE.Repository
{
    public class BlogTagRepository : Repository<BlogTag>
    {
        public BlogTagRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
