using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";

            //veya 

            Product product1 = new Product { Id = 2, CategoryId = 5, ProductName = "kalem" };

            //PascalCase (class adı büyük başlar)  // camelCase(başta küçük sonra büyük harf)
            //case sensitive (büyük küçük harf duyarlılık)
            
            ProductManager productManager = new ProductManager() ;
            productManager.Add(product);

        }
    }
}
