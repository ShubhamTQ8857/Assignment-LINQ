using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLINQ1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string CompanyName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Price=799,CompanyName="Dell"},
                new Product{Id=2,Name="Mouse",Price=699,CompanyName="Lenovo"},
                new Product{Id=3,Name="Laptop",Price=34799,CompanyName="Dell"},
                new Product{Id=4,Name="Laptop",Price=45799,CompanyName="Sony"},
                new Product{Id=5,Name="Laptop",Price=38799,CompanyName="Lenovo"},
                new Product{Id=6,Name="Keyboard",Price=599,CompanyName="Dell"},
                new Product{Id=7,Name="Keyboard",Price=999,CompanyName="Microsoft"},
                new Product{Id=8,Name="RAM 4GB",Price=2799,CompanyName="Corsair"},
                new Product{Id=9,Name="Speaker",Price=5799,CompanyName="Sony"},
                new Product{Id=10,Name="USB Mouse",Price=1299,CompanyName="Microsoft"},
            };

            //Display All Products
            var res = from p in products select p;
          
            var res2 = from p in products
                       where p.Price > 1500
                       select p;
           
            var res3 = from p in products
                       where p.Price >= 10000 && p.Price <= 40000
                       select p;
            
            var res4 = from p in products
                       where p.CompanyName == "dell"
                       select p;
          
            var res5 = from p in products
                       where p.Name == "Laptop"
                       select p;
            
            var res6 = from p in products
                       where p.CompanyName.StartsWith("M")
                       select p;
            
            var res7 = from p in products
                       where p.Name == "Mouse" && p.Price < 1000
                       select p;
            
            var res8 = from p in products
                       orderby p.Price descending
                       select p;
           
            var res9 = from p in products
                       orderby p.Name
                       select p;
          
            var res10 = from p in products
                        orderby p.Price
                        where p.Name == "keyboards"
                        select p;
       
            var res11 = products.OrderBy(x => x.Price).ToList();
            
            var res12 = products.Where(x => x.Id == '5').ToList();
            
            var res13 = products.Where(x => x.Price < 5000).ToList();
           
            var res14 = products.OrderByDescending(x => x.Price).ToList();
         
            var res15 = products.OrderBy(x => x.Price).ToList();




            foreach (Product item in res8)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Price}");
            }
        }
    }
}