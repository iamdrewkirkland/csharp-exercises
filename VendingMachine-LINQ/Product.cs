using System;

namespace Vending
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name} (ID: {Id}) costs ${Price}");
        }
    }
}
