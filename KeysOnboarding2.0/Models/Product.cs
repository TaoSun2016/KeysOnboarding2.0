using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeysOnboarding.Models
{
    public class Product
    {
        public virtual int Id { get; set; }
        [Display(Name = "Product Name")]
        public virtual string Name { get; set; }
        [Display(Name = "Product Price")]
        public virtual decimal Price { get; set; }
        public virtual List<ProductSold> ProductSolds { get; set; }
    }
}