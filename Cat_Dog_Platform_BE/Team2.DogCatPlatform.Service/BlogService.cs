using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Model;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service
{
    public class BlogService : IBlogService
    {
        private SwpProjectContext _context = new SwpProjectContext();   

        public Blog GetBlogById(string id)
        {
            return _context.Blogs.Where(b => b.IdBlog == id).FirstOrDefault();
        }

        public ICollection<Blog> GetBlog()
        {
            return _context.Blogs.OrderBy(p => p.IdBlog).ToList();
        }

        public bool BlogExists(string BlogId)
        {
            return _context.Blogs.Any(p => p.IdBlog.Contains(BlogId));
        }

        public Blog GetBlogbyTitle(string Title)
        {
            return _context.Blogs.Where(b => b.BlogTitle.Equals(Title)).FirstOrDefault();
        }
    }
}
