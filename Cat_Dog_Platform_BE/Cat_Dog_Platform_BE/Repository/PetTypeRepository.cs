using Cat_Dog_Platform_BE.Entity;
using Repository;

namespace Cat_Dog_Platform_BE.Repository
{
    public class PetTypeRepository : Repository<PetType>
    {
        public PetTypeRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
