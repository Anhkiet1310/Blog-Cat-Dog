using Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Entity;

namespace Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Repository
{
    public class TagRepository : Repository<Tag>
    {
        public TagRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
