using Cat_Dog_Platform_PE.Entity;
using Repository;

namespace Cat_Dog_Platform_PE.Repository
{
    public class PetTypeRepository : Repository<PetType>
    {
        public PetTypeRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
