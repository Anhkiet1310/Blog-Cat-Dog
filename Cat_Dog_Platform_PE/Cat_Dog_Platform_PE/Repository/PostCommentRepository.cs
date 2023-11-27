using Cat_Dog_Platform_PE.Entity;
using Repository;

namespace Cat_Dog_Platform_PE.Repository
{
    public class PostCommentRepository : Repository<PostComment>
    {
        public PostCommentRepository(BlogAnimalContext _context) : base(_context)
        {
        }

    }
}
