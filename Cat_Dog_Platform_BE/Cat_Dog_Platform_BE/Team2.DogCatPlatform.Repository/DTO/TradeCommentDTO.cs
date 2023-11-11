using Cat_Dog_Platform_BE.DTO;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.DTO
{
    public class TradeCommentDTO
    {
        public string Content { get; set; } = null!;
        public DateTime? CreateDate { get; set; }
        public string? AccountId { get; set; }
        public string? TradeId { get; set; }

        public virtual AccountDTO? Account { get; set; }
    }
}
