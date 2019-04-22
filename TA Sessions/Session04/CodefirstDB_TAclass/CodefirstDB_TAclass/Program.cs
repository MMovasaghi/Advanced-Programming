using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodefirstDB_TAclass
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                //db.Blogs.Add(
                //    new Blog
                //    {
                //        Url = "google.com",
                //        Posts = new List<Post>
                //        {
                //            new Post()
                //            {
                //                Title = "title",
                //                Content = "Hi",
                //            },
                //        }
                //    });


                //var count = db.SaveChanges();
                //Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.Write(" - {0}", blog.Url);
                    if (blog.Posts != null)
                    {
                        foreach (var post in blog.Posts)
                        {
                            Console.Write("Posts list : Title : {0}", post.Title);
                        }
                    }                    
                    Console.Write("\n");
                }
            }
        }
    }
}
