using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Models
{
    public class BlogRepo : IBlogRepo
    {
        public BlogRepo()
        {

        }

        public BlogPost GetPost()
        {
            var post = new BlogPost
            {
                PostId = 123,
                Title = "Hello Hesehus!",
                Description = "This is ASP.NET 5!"
            };

            return post;
        }
    }
}
