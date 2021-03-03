using System;

namespace Sales_System2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.name = "Chocolate";
            p1.price = 5000;
            Product p2 = new Product();
            p2.name = "Cheese";
            p2.price = 2600;
            Product p3 = new Product();
            p3.name = "Milk";
            p3.price = 3200;

            Seller s1 = new Seller();
            s1.name = "Arturo";
            s1.age = 25;
            Seller s2 = new Seller();
            s2.name = "Juan";
            s2.age = 21;
            Seller s3 = new Seller();
            s3.name = "Maria";
            s3.age = 27;
            
            Sale sale1 = new Sale();
            float sl1 = sale1.CountPrice(p1.price, p2.price, 0);
            sale1.comments = s2.name;
            Sale sale2 = new Sale();
            float sl2 = sale2.CountPrice(0, 0, p3.price);
            sale2.comments = s3.name;
            Sale sale3 = new Sale();
            float sl3 = sale3.CountPrice(0, p2.price, p3.price);
            sale3.comments = s1.name;

            Console.WriteLine("La primera venta es de " + sl1 + " hecha por " + sale1.comments);
            Console.WriteLine("La segunda venta es de " + sl2 + " hecha por " + sale2.comments);
            Console.WriteLine("La tercera venta es de " + sl3 + " hecha por " + sale3.comments);
        }
    }
}
