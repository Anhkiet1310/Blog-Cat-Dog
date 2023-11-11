using Cat_Dog_Platform_BE.Entity;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Helper;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Repository
{
    public class TradeCommentRepository : Repository<TradeComment>
    {
        private readonly Util util;

        public TradeCommentRepository(BlogAnimalContext _context, Util _util) : base(_context)
        {
            util = _util;
        }
    }
}
