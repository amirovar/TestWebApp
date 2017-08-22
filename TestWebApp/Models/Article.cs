using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestWebApp.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set;}
        public DateTime ReleaseDateP { get; set; }
        public string ImgPath { get; set; }
        public string Text { get; set; }
    }

    public class ArticleDBContext : DbContext
    {
        public DbSet<Article> Articlies { get; set; }
    }
}