using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeysOnboarding.Models
{
    public class Customer
    {
        public virtual int Id { get; set; }
        [Display(Name = "Customer Name")]
        public virtual string Name { get; set; }
        [Display(Name = "Customer Address")]
        public virtual string   Address { get; set; }
        public virtual List<ProductSold> ProductSolds { get; set; }
    }
}