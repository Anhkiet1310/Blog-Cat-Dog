using System;
using System.Collections.Generic;

namespace Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Entity
{
    public partial class PetType
    {
        public PetType()
        {
            Blogs = new HashSet<Blog>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; } = null!;
        public string? Image { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
