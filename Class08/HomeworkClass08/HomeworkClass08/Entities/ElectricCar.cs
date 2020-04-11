using System;
using System.Collections.Generic;
using System.Text;
using HomeworkClass08.Enums;

namespace HomeworkClass08.Entities
{
    public class ElectricCar : Car
    {
        public ElectricCar()
        {
            EngineType = EngineType.electric;
        }
        public int BatteryCapacity { get; set; }
        public int BatteryUsage { get; set; }
        public int Drive(Car car, int distance)
        {
            int batteryUsed = distance * (int)car.Consumption / 10;
            if (batteryUsed > BatteryCapacity)
            {
                Console.WriteLine("You are not allowed to drive more than your battery capacity!");
                return batteryUsed = 0;
            }
            else
                return batteryUsed;
        }
        
        public int Recharge(Car car, int minutes)
        {
            int percent = minutes / 10;
            if (percent > 100)
            {
                Console.WriteLine($"Can't charge longer than {0} minutes!",minutes);
                return percent;
            }
            return percent;
        }
    }
}
