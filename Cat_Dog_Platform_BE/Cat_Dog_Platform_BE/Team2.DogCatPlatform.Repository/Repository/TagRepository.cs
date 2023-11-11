using Cat_Dog_Platform_BE.Entity;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Repository;

namespace Cat_Dog_Platform_BE.Repository
{
    public class TagRepository : Repository<Tag>
    {
        public TagRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
