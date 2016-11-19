using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace toysRus.Models
{
    public class Toy
    {
        [HiddenInput][Required]
        public int ID { get; set; }

        [Required][MinLength(3)][Display(Name ="Product Name")]
        public string Name { get; set; }

        [Required][MinLength(10)][Display(Name = "Description")]
        public string Description { get; set; }

        [Required][Range(0.1, double.MaxValue)][Display(Name = "Price")]
        public double Price { get; set; }

        [Required][Display(Name = "Product Image")]
        public string ImageUrl { get; set; }

        [Required][Range(0, int.MaxValue)][Display(Name = "Quantity")]
        public int Available { get; set; }

        public virtual Category Category { get; set; }

        public virtual User Seller { get; set; }

        public Toy()
        {

        }

        public Toy(Toy source)
        {
            this.ID = source.ID;
            this.Name = source.Name;
            this.Description = source.Description;
            this.Price = source.Price;
            this.ImageUrl = source.ImageUrl;
            this.Available = source.Available;
            this.Category = source.Category;
            this.Seller = source.Seller;
        }        
    }
}