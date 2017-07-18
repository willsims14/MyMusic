﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMusic.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Title { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        public virtual List<Review> Review { get; set; }


    }
}