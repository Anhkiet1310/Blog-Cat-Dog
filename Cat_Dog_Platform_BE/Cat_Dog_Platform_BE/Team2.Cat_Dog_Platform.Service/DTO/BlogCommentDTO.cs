

namespace Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Service.DTO
{
    public class BlogCommentDTO
    {
        public int CommentId { get; set; }
        public string Content { get; set; } = null!;
        public string? BlogId { get; set; }
        public string? AccountId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual AccountDTO? Account { get; set; }
    }
}
