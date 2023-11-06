namespace Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Service.DTO
{
    public class BlogTypeDTO
    {
        public BlogTypeDTO()
        {
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; } = null!;
        public string? Image { get; set; }

    }
}
