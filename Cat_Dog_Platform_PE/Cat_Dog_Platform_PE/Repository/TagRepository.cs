using Cat_Dog_Platform_PE.Entity;
using Repository;

namespace Cat_Dog_Platform_PE.Repository
{
    public class TagRepository : Repository<Tag>
    {
        public TagRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
