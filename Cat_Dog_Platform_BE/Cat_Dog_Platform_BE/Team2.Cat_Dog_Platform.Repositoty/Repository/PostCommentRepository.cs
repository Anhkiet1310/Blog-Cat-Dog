using Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Entity;

namespace Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Repository
{
    public class PostCommentRepository : Repository<PostComment>
    {
        public PostCommentRepository(BlogAnimalContext _context) : base(_context)
        {
        }

    }
}
