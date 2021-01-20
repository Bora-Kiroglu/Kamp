using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Sandalye";
            product1.UnitPrice = 399.99;
            product1.UnitsInStock = 49;

            Product product2 = new Product{Id = 2, CategoryId = 5, UnitsInStock = 7, ProductName = "Kalem", UnitPrice = 7};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
