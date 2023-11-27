namespace Cat_Dog_Platform_PE.DTO
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
