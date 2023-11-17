using Cat_Dog_Platform_BE.Entity;
using Repository;

namespace Cat_Dog_Platform_BE.Repository
{
    public class PostCommentRepository : Repository<PostComment>
    {
        public PostCommentRepository(BlogAnimalContext _context) : base(_context)
        {
        }

    }
}
