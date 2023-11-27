using Cat_Dog_Platform_PE.Entity;
using Cat_Dog_Platform_PE.Helper;
using Repository;

namespace Cat_Dog_Platform_PE.Repository
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
