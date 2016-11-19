using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace toysRus.Models
{
    public class User : IdentityUser
    {
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public virtual ICollection<Toy> Toys { get; set; }
    }
}