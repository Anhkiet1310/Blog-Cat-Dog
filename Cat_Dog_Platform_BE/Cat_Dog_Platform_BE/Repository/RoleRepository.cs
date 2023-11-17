using Cat_Dog_Platform_BE.Entity;
using Repository;

namespace Cat_Dog_Platform_BE.Repository
{
    public class RoleRepository : Repository<Role>
    {
        public RoleRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
