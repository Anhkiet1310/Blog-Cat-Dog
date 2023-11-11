using AutoMapper;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Repository;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.DTO;
using Cat_Dog_Platform_BE.DTO;
using Cat_Dog_Platform_BE.Entity;

namespace Cat_Dog_Platform_BE.Services
{
    public class TradeService : Service
    {
        private readonly TradeRepository tradeRepo;
        private readonly TradeCommentRepository tradeCommentRepo;

        public TradeService(IMapper _mapper, TradeRepository _tradeRepo, TradeCommentRepository tradeCommentRepository) : base(_mapper)
        {
            tradeRepo = _tradeRepo;
            tradeCommentRepo = tradeCommentRepository;
        }

        public async Task<List<TradeDTO>> getAll()
        {
            List<TradePost> trades = await tradeRepo.getAll();
            List<TradeDTO> tradeDTOs = mapper.Map<List<TradeDTO>>(trades);
            return tradeDTOs;
        }

        public async Task commentTrade(TradeCommentDTO tradeCommentDTO)
        {
            TradeComment tc = mapper.Map<TradeComment>(tradeCommentDTO);
            await tradeCommentRepo.add(tc);
        }

        public async Task setTrade(string tradeId)
        {
            await tradeRepo.setTrade(tradeId);
        }

        public async Task deleteTrade(string tradeId)
        {
            await tradeRepo.delOne(tradeId);
        }

        public async Task<string> editPassword(string accountId, string oldpasswod, string newpassword)
        {
            return await accountRepo.editPassword(accountId, oldpasswod, newpassword);
        }

        public async Task createTrade(TradeDTO tradeDTO)
        {
            TradePost tc = mapper.Map<TradePost>(tradeDTO);
            await tradeRepo.add(tc);
        }

        public async Task secureTrade(string id)
        {
            await tradeRepo.secureTrade(id);
        }
    }
}
