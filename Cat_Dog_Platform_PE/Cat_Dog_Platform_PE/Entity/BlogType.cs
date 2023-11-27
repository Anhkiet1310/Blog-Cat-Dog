using System;
using System.Collections.Generic;

namespace Cat_Dog_Platform_PE.Entity
{
    public partial class BlogType
    {
        public BlogType()
        {
            Blogs = new HashSet<Blog>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; } = null!;
        public string? Image { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
