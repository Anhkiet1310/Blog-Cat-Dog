using Cat_Dog_Platform_PE.Entity;

namespace Cat_Dog_Platform_PE.DTO
{
    public class PostLikeDTO
    {
        public int LikeId { get; set; }
        public string? PostId { get; set; }
        public string? AccountId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual AccountDTO? Account { get; set; }
    }
}
