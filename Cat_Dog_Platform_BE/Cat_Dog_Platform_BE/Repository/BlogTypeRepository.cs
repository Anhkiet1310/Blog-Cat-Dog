using Cat_Dog_Platform_BE.Entity;
using Repository;

namespace Cat_Dog_Platform_BE.Repository
{
    public class BlogTypeRepository : Repository<BlogType>
    {
        public BlogTypeRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
