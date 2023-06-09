﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public decimal Price { get; set; }

#nullable enable
        public string? Title { get; set; }

        public string? Genre { get; set; }
    }
}
