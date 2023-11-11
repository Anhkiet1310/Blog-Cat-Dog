using Cat_Dog_Platform_BE.Entity;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Repository
{
    public class RoleRepository : Repository<Role>
    {
        public RoleRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
