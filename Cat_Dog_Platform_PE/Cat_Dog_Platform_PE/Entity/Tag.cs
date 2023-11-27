using System;
using System.Collections.Generic;

namespace Cat_Dog_Platform_PE.Entity
{
    public partial class Tag
    {
        public Tag()
        {
            BlogTags = new HashSet<BlogTag>();
        }

        public int TagId { get; set; }
        public string TagName { get; set; } = null!;

        public virtual ICollection<BlogTag> BlogTags { get; set; }
    }
}
