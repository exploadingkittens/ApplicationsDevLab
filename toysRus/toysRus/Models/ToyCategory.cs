using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace toysRus.Models
{
    public class ToyCategory
    {
        [HiddenInput][Required]
        public int ID { get; set; }

        [Required][MinLength(3)]
        public string Name { get; set; }

        public virtual ICollection<Toy> Products { get; set; }
    }
}