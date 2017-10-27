﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KeysOnboarding2._0.Models
{
    public class DBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DBContext() : base("name=DBContext")
        {
        }

        public System.Data.Entity.DbSet<KeysOnboarding.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<KeysOnboarding.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<KeysOnboarding.Models.Store> Stores { get; set; }

        public System.Data.Entity.DbSet<KeysOnboarding.Models.ProductSold> ProductSolds { get; set; }
    }
}
