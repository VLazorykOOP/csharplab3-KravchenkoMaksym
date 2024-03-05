using System;

namespace Task_2
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Товар: {Name}, Цiна: {Price}");
        }
    }

    class Toy : Product
    {
        public string AgeRange { get; set; }

        public Toy(string name, double price, string ageRange)
            : base(name, price)
        {
            AgeRange = ageRange;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Вiковий дiапазон: {AgeRange}");
        }
    }

    class DairyProduct : Product
    {
        public DateTime ExpiryDate { get; set; }

        public DairyProduct(string name, double price, DateTime expiryDate)
            : base(name, price)
        {
            ExpiryDate = expiryDate;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Термiн придатностi: {ExpiryDate.ToShortDateString()}");
        }
    }

    class Program
    {
        static void Main()
        {
            Product[] products = new Product[3];

            products[0] = new Toy("Ведмiдь", 15.99, "3-6 рокiв");
            products[1] = new DairyProduct("Молоко", 2.49, DateTime.Now.AddMonths(1));
            products[2] = new Product("Книга", 9.99);

            ShowProducts(products);
        }

        static void ShowProducts(Product[] products)
        {
            foreach (var product in products)
            {
                product.Show();
                Console.WriteLine();
            }
        }
    }
}
