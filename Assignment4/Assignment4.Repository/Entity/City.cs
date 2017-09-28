﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Repository.Entity
{
   public class City
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }

    }
}
