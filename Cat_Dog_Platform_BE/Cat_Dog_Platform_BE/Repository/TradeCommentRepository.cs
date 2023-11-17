using Cat_Dog_Platform_BE.Entity;
using Cat_Dog_Platform_BE.Helper;
using Repository;

namespace Cat_Dog_Platform_BE.Repository
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
