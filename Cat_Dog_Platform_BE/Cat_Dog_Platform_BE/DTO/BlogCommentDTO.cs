using Cat_Dog_Platform_BE.Entity;

namespace Cat_Dog_Platform_BE.DTO
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
