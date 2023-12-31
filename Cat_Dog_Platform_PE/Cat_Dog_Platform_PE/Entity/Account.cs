﻿using System;
using System.Collections.Generic;

namespace Cat_Dog_Platform_PE.Entity
{
    public partial class Account
    {
        public Account()
        {
            BlogComments = new HashSet<BlogComment>();
            Blogs = new HashSet<Blog>();
            PostComments = new HashSet<PostComment>();
            PostLikes = new HashSet<PostLike>();
            Posts = new HashSet<Post>();
            TradeComments = new HashSet<TradeComment>();
            TradePosts = new HashSet<TradePost>();
        }

        public string AccountId { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string? HashPassword { get; set; }
        public string Email { get; set; } = null!;
        public string? Contact { get; set; }
        public string? Facebook { get; set; }
        public bool? IsBanned { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<BlogComment> BlogComments { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<PostComment> PostComments { get; set; }
        public virtual ICollection<PostLike> PostLikes { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<TradeComment> TradeComments { get; set; }
        public virtual ICollection<TradePost> TradePosts { get; set; }
    }
}
