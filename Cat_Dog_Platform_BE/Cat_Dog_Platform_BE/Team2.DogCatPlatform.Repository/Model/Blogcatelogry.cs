using System;
using System.Collections.Generic;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Model;

public partial class Blogcatelogry
{
    public string IdBlogCatelogry { get; set; } = null!;

    public string? NameCatelogry { get; set; }

    public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();
}
