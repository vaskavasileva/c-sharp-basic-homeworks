using HomeworkClass08.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClass08.Entities
{
    public class Car
    {
        public Car()
        {
            Id = new Random().Next(0, 1000);
        }
        public int Id { get; set; }
        public string Brand { get; set; }
        public  string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consumption { get; set; }
        public EngineType EngineType { get; set; }


        public void PrintInfo(Car car)
        {
            Console.WriteLine("The brand of the car is: " + car.Brand + ".");
            Console.WriteLine("The model of the car is: " + car.Model + ".");
            Console.WriteLine($"The car has {0} doors.", car.Doors);
            Console.WriteLine($"The top speed of the car is {0}.", car.TopSpeed);
            Console.WriteLine($"The car has {0} consumption.", car.Consumption);
            Console.WriteLine("The engine type is: " + car.EngineType);
        }
    }
}
