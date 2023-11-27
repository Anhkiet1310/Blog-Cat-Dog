using System;
using System.Collections.Generic;

namespace Cat_Dog_Platform_PE.Entity
{
    public partial class BlogTag
    {
        public int BlogTagId { get; set; }
        public int? TagId { get; set; }
        public string? BlogId { get; set; }

        public virtual Blog? Blog { get; set; }
        public virtual Tag? Tag { get; set; }
    }
}
