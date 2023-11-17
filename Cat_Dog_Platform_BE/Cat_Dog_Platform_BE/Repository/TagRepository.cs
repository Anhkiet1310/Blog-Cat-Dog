using Cat_Dog_Platform_BE.Entity;
using Repository;

namespace Cat_Dog_Platform_BE.Repository
{
    public class TagRepository : Repository<Tag>
    {
        public TagRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
