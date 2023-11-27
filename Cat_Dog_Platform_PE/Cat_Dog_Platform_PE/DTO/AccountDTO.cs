using Cat_Dog_Platform_PE.Entity;

namespace Cat_Dog_Platform_PE.DTO
{
    public class AccountDTO
    {
        public AccountDTO()
        {
        }

        public string AccountId { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Contact { get; set; }
        public string? Facebook { get; set; }
        public bool? IsBanned { get; set; }
        public int? RoleId { get; set; }

        public virtual RoleDTO? Role { get; set; }
    }
}
