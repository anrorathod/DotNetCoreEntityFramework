using DBDemo.Business;
using System;
using System.Linq;

namespace DBDemo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();

                if (name == "exit")
                {
                    break;
                }

                Console.WriteLine("Enter url:");
                string url = Console.ReadLine();

                var blog = new Blog { Name = name, Url = url };
                BLBlog.Save(blog);

                var blogs = BLBlog.GetBlogs();

                foreach (var item in blogs)
                {
                    Console.WriteLine(item.Name);
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
