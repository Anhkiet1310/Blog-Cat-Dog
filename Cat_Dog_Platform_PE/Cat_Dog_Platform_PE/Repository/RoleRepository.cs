using Cat_Dog_Platform_PE.Entity;
using Repository;

namespace Cat_Dog_Platform_PE.Repository
{
    public class RoleRepository : Repository<Role>
    {
        public RoleRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
