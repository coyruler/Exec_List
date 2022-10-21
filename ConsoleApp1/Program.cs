using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {//宣告一個List<Product>變數,存放多筆購買商品

            List<Product> products= new List<Product>();
            products.Add(new Product() {Id=0, ProductName="abc", Price=123 });
            products.Add(new Product() {Id = 1, ProductName = "abcd", Price = 1234 });

            foreach (Product producti in products)
            {
                Console.WriteLine(producti.Id);
                Console.WriteLine(producti.ProductName);
                Console.WriteLine(producti.Price);
            }
            
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

    }
}
