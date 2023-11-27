using Cat_Dog_Platform_PE.Entity;

namespace Cat_Dog_Platform_PE.DTO.requestDTO
{
    public class createBlogDTO
    {
        public createBlogDTO()
        {
        }
        public string? BlogId { get; set; }
        public string Title { get; set; }   
        public string Content { get; set; }
        public string AccountId { get; set; }
        public int BlogTypeId { get; set;}
    }
}
