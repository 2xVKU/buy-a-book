﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FirstTry.Models;

namespace LetsGetThisDone.Models
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }
        public string CartId { get; set; }
        public int ItemId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Book Book { get; set; }
    }
}