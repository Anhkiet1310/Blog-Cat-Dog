﻿using System;
using System.Collections.Generic;

namespace Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Entity
{
    public partial class PostComment
    {
        public int CommentId { get; set; }
        public string Content { get; set; } = null!;
        public string? PostId { get; set; }
        public string? AccountId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Post? Post { get; set; }
    }
}