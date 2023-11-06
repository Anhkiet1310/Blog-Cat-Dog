namespace Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Service.DTO.requestDTO
{
    public class SignUpDTO
    {
        public string Username { get; set; } = null!;
        public string? HashPassword { get; set; }
        public string Email { get; set; } = null!;
    }
}
