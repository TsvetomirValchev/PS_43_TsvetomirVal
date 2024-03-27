﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Welcome.Model;

namespace DataLayer.Model
{
    public class DatabaseUser : User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int ID
        {
            get; set;

        }

        public DateTime Expires { get; set; }
    }
}
