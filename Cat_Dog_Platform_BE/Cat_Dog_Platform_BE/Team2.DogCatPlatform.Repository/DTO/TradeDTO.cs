using Cat_Dog_Platform_BE.Entity;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.DTO;

namespace Cat_Dog_Platform_BE.DTO
{
    public class TradeDTO
    {
        public string? TradeId { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool? IsTrade { get; set; }
        public bool? IsSecure { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? AccountId { get; set; }

        public virtual AccountDTO? Account { get; set; }
        public virtual ICollection<TradeCommentDTO>? TradeComments { get; set; }
    }
}
