using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>{
    new Product{
        Name="React JS",
        Description="React JS Platform",
         Price =20000,
         PictureUrl ="/images/products/rr.png",
         Type ="Boards",
         Brand ="React",
         QuantityInStock =2,
    },
     new Product{
        Name="Angular",
        Description="Angular Platform",
         Price =10000,
         PictureUrl ="/images/products/aa.png",
         Type ="Boards",
         Brand ="Ang",
         QuantityInStock =4,
    }
};
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}