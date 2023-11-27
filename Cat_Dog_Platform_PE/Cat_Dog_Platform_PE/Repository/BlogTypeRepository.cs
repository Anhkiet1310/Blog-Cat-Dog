using Cat_Dog_Platform_PE.Entity;
using Repository;

namespace Cat_Dog_Platform_PE.Repository
{
    public class BlogTypeRepository : Repository<BlogType>
    {
        public BlogTypeRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
