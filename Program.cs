using System;

namespace odev6
{
    class Products
    {
        static void Main(string[] args)
        {
          Product product1 = new Product();
          product1.productName = "Çay";
          product1.productAmount = "24TL";
          product1.productPrice = "1000gr";
          
          Product product2 = new Product();
          product2.productName = "Bal";
          product2.productAmount = "18TL";
          product2.productPrice = "300gr";
          
          Product product3 = new Product();
          product3.productName = "Kahve";
          product3.productAmount = "26TL";
          product3.productPrice = "2000gr";
        
         Product[] products = new Product[] {product1,product2,product3 };
          
          Console.WriteLine("\nforeach ---");
         foreach (var product in products)
         {
          Console.WriteLine(product.productName + " : " + product.productPrice + " : " + product.productAmount);
         }
         
          Console.WriteLine("\nfor ---");
         for (var i = 0; i<products.Length;i++)
         {
           Console.WriteLine(products[i].productName + " : " + products[i].productPrice + " : " + products[i].productAmount);
         }
         
           Console.WriteLine("\nwhile ---");
         int sayac = 0;
         while (sayac < products.Length)
         {
         Console.WriteLine(products[sayac].productName + " : " + products[sayac].productPrice + " : " + products[sayac].productAmount);
         sayac++;
         }   

     }   
         
        }
     class Product
     {
      public string productName { get; set; }
   
      public string productPrice { get; set; }
    
      public string productAmount { get; set; }
     }
}

