using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyMusic.Models
{
    public class MyMusicContext27 : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyMusicContext27() : base("name=MyMusicContext27")
        {
        }

        public System.Data.Entity.DbSet<MyMusic.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<MyMusic.Models.Artist> Artists { get; set; }

        public System.Data.Entity.DbSet<MyMusic.Models.Review> Reviews { get; set; }

        public System.Data.Entity.DbSet<MyMusic.Models.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<MyMusic.Models.Song> Songs { get; set; }
    }
}
