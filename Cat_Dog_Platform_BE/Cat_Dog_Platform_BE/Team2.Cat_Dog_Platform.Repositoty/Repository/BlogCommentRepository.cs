﻿using Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Entity;

namespace Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Repository
{
    public class BlogCommentRepository : Repository<BlogComment>
    {
        public BlogCommentRepository(BlogAnimalContext _context) : base(_context)
        {
        }
    }
}