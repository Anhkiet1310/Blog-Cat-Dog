using BlogAnimalApi.Entity;
using Repository;

namespace BlogAnimalApi.Team2.Cat_Dog_Platform.Repositoty.Repository
{
    public class BlogTagRepository : Repository<BlogTag>
    {
        public BlogTagRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}
