using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using toysRus.Models;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace toysRus.Models
{
    public class Purchase
    {
        [HiddenInput][Required]
        public int ID { get; set; }

        public DateTime SaleTime { get; set; }

        public int Amount { get; set; }

        public double TotalPrice { get; set; }

        public virtual Toy Toy { get; set; }

        public virtual User User { get; set; }
    }
}