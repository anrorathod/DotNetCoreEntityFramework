using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBDemo.Business
{
    public class BLBlog
    {
        public static void Save(Blog blog)
        {

            using (var db = new BlogContext())
            {
                db.Database.EnsureCreated();

                db.Blogs.Add(blog);

                db.SaveChanges();
            }
        }


        public static List<Blog> GetBlogs()
        {
            using (var db = new BlogContext())
            {
                var blogs = db.Blogs
                     .OrderBy(o => o.Name)
                     .ToList();
                return blogs;
            }
        }

    }
}
