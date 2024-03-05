using System;


namespace Task_1
{
    class ATriangle
    {
        // Поля
        protected int a;
        protected int b;
        private readonly string color; // колір трикутника

        // Конструктор
        public ATriangle(int sideA, int sideB, string triangleColor)
        {
            a = sideA;
            b = sideB;
            color = triangleColor;
        }

        // Методи
        public void PrintSides()
        {
            Console.WriteLine($"Сторони трикутника: a = {a}, b = {b}, гiпотенуза = {GetHypotenuse()}");
        }

        public double CalculatePerimeter()
        {
            return a + b + GetHypotenuse();
        }

        public double CalculateArea()
        {
            return 0.5 * a * b;
        }

        public bool IsIsosceles()
        {
            return a == b || a == GetHypotenuse() || b == GetHypotenuse();
        }

        // Властивості
        public int SideA
        {
            get { return a; }
            set { a = value; }
        }

        public int SideB
        {
            get { return b; }
            set { b = value; }
        }

        public string Color
        {
            get { return color; }
        }

        // Приватний метод для розрахунку гіпотенузи
        private double GetHypotenuse()
        {
            return Math.Sqrt(a * a + b * b);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введiть сторону a:");
            int sideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть сторону b:");
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть колiр трикутника:");
            string triangleColor = Console.ReadLine();

            ATriangle triangle = new ATriangle(sideA, sideB, triangleColor);

            Console.WriteLine("Iнформацiя про трикутник:");
            triangle.PrintSides();
            Console.WriteLine($"Периметр: {triangle.CalculatePerimeter()}");
            Console.WriteLine($"Площа: {triangle.CalculateArea()}");
            Console.WriteLine($"Чи є рiвнобедреним: {triangle.IsIsosceles()}");
            Console.WriteLine($"Колiр трикутника: {triangle.Color}");
        }
    }
}