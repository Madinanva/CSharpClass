using System;
namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            Cat cat1 = new Cat();

                cat1.name = "Garfield";
                cat1.age = 3;
                cat1.color = "orange";

                Dog dog1 = new Dog();
                dog1.name = "Luna";
                dog1.age = 5;
                dog1.color = "brown";

            Car car1 = new Car();
            car1.brand = "BMW";
            car1.price = "21.000";
            car1.speed = "235km/h";
            car1.color = "white";

            Car car2 = new Car();
            car2.brand = "Mercedes";
            car2.price = "360.000";
            car2.speed = "255km/h";
            car2.color = "black";

            Console.WriteLine($"{cat1.name} {cat1.age} {cat1.color}");
            Console.WriteLine($"{dog1.name} {dog1.age} {dog1.color}");

            Console.WriteLine($"{car1.brand} {car1.price} {car1.speed} {car1.color}");
            Console.WriteLine($"{car2.brand} {car2.price} {car2.speed} {car2.color}");
          
        }
    }
}