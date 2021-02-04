using System;

namespace Car.Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var car = new Car();
            car.Milleage = int.Parse(Console.ReadLine());
            Console.WriteLine(car.Milleage);
            Console.WriteLine("Let's go N kilometers:");
            var distance = int.Parse(Console.ReadLine());
            car.Go(distance);
            Console.WriteLine(car.Milleage);
        }
    }

    class Car
    {
        private int milleage;
        public string Make { get; set; }

        public string Model { get; set; }

        public int Milleage
        {
            get { return milleage; }
            set { milleage = value; }
        }

        public string Rank
        {
            get
            {
                if (milleage < 100000)
                {
                    return "A";
                }
                else
                {
                    return "B";
                }
            }
        }

        public void Go(int distance)
        {
            Milleage = Milleage + distance;
        }
    }
}
