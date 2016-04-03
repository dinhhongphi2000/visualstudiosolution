using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MigrationsDemo.Migrations;

namespace MigrationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogDbContext, Configuration>());      
            using(var db = new BlogDbContext())
            {
                db.Blogs.Add(new Blog { Name = "Another Blog" });
                db.SaveChanges();
                foreach(var blog in db.Blogs)
                {
                    Console.WriteLine("ID ={0}  Name = {1}",blog.BlogId,blog.Name);
                }
            }
        }
    }
}
