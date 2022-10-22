using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week3_homework
{
    public class CartItem
    {
        public int CartId { get; set; }

        public Product? Product { get; set; }

        public int Quantity { get; set; }


        public override string? ToString()
        {
            return $"----------------\n" +
            $"ProductId: {Product.ProductId}\n" +
            $"ProductName: {Product.ProductName}\n" +
            $"Price: {Product.Price}\n" +
            $"Quantity: {Quantity}\n" +
            $"------------------";
        }

    }
}
