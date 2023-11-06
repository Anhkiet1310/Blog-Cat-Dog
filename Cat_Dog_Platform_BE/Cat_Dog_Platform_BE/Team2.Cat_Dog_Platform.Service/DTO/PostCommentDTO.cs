

namespace Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Service.DTO
{
    public class PostCommentDTO
    {
        public int CommentId { get; set; }
        public string Content { get; set; } = null!;
        public string? PostId { get; set; }
        public string? AccountId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual AccountDTO? Account { get; set; }
    }
}
