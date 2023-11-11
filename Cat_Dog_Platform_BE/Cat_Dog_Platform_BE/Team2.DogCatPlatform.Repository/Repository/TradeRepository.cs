using Cat_Dog_Platform_BE.Entity;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Helper;
using Microsoft.EntityFrameworkCore;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Repository
{
    public class TradeRepository : Repository<TradePost>
    {
        private readonly Util util;

        public TradeRepository(BlogAnimalContext _context, Util _util) : base(_context)
        {
            util = _util;
        }

        public async Task<List<TradePost>> getAll()
        {
            return await context.TradePosts.Include(t => t.Account).Include(a => a.TradeComments).ThenInclude(t => t.Account).ToListAsync();
        }

        public async Task setTrade(string tradeId)
        {
            TradePost trade = await context.TradePosts.FindAsync(tradeId);
            trade.IsTrade = true;
            await context.SaveChangesAsync();
        }

        public async Task delOne(string tradeId)
        {
            TradePost trade = await context.TradePosts.Include(a => a.TradeComments).FirstOrDefaultAsync(t => t.TradeId.Equals(tradeId));
            if (trade != null)
            {
                context.TradePosts.Remove(trade);
                await context.SaveChangesAsync();
            }
        }

        public async Task secureTrade(string tradeId)
        {
            TradePost trade = await context.TradePosts.FindAsync(tradeId);
            trade.IsSecure = true;
            await context.SaveChangesAsync();
        }

    }
}
