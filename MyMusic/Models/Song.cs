using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMusic.Models
{
    public class Song
    {
        public int SongId { get; set; }
   
        public string Title { get; set; }

        public virtual Album Album { get; set; }
        public int AlbumId { get; set; }

        public virtual Genre Genre { get; set; }
        public int GenreId { get; set; }


    }
}