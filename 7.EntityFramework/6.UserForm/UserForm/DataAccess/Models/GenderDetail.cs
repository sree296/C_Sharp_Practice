﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("GenderDetails")]
    public class GenderDetail
    {
        [Key]
        public int GId { get; set; }
        public string GName { get; set; }
    }
}
