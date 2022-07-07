using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Car
    {
        public string name;
        public string brand;
        public string price;
        public string speed;
        public string color;

        public Car()
        {
         
        }
        public Car(string brand, string price, string speed, string color) : this()
        {
            this.brand = brand;
            this.price = price;
            this.speed = speed;
            this.color = color;

            Console.WriteLine("Custom constructor worked");
        }   
        public string GetDetails()
        {
            return $"{brand} {price} {speed} {color}";
        }
    }
}
