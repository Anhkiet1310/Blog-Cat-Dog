using Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Entity;
using Microsoft.EntityFrameworkCore;

namespace Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Repository
{
    public class PostLikeRepository : Repository<PostLike>
    {
        public PostLikeRepository(BlogAnimalContext _context) : base(_context)
        {
        }

        public async Task<PostLike> getPostLikeByAccAndPost(string postId, string accId)
        {
            PostLike postLike = await context.PostLikes.FirstOrDefaultAsync(like => like.AccountId.Equals(accId)
                                                                                        && like.PostId.Equals(postId));
            return postLike;
        }
    }
}
