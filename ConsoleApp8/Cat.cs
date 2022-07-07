using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Cat
    {
        public string name;
        public string color;
        public byte age; 
        public Cat()
        {
            Console.WriteLine("custom constructor worked");
        }
        public Cat(string name, string color, byte age)
        {
            this.name = name;
            this.color = color;
            this.age = age;
            
            
        }
        public string Getdetails()
        {
            return $"{name} {color} {age}";
        }
    }
}
