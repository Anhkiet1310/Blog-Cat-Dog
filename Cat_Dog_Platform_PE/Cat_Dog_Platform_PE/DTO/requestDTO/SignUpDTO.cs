namespace Cat_Dog_Platform_PE.DTO.requestDTO
{
    public class SignUpDTO
    {
        public string Username { get; set; } = null!;
        public string? HashPassword { get; set; }
        public string Email { get; set; } = null!;
    }
}
