using Cat_Dog_Platform_BE.Entity;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Repository
{
    public class PostCommentRepository : Repository<PostComment>
    {
        public PostCommentRepository(BlogAnimalContext _context) : base(_context)
        {
        }

    }
}
