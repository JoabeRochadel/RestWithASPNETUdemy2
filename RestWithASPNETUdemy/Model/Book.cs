﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("Books")]
    public class Book
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("author")]
        public string author { get; set; }

        [Column("launch_date")]
        public DateTime launch_date { get; set; }

        [Column("price")]
        public decimal price { get; set; }

        [Column("title")]
        public string title { get; set; }
    }
}
