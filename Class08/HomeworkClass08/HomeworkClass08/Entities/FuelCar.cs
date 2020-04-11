using System;
using System.Collections.Generic;
using System.Text;
using HomeworkClass08.Enums;

namespace HomeworkClass08.Entities
{
    public class FuelCar : Car
    {
        public FuelCar(EngineType petrol)
        {
            EngineType = EngineType.petrol;
        }
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }


        public int Drive(Car car, int distance)
        {
            int fuelUsed = distance * (int)car.Consumption / 10;
            if (fuelUsed > FuelCapacity)
            {
                Console.WriteLine("You are not allowed to drive more than your fuel capacity!");
                return fuelUsed = 0;
            }
            else
                return fuelUsed;
        }

        public int Refuel(Car car, int fuel)
        {
            CurrentFuel += fuel;
            if (CurrentFuel <= FuelCapacity)
            {
                return CurrentFuel;
            }

            else
            {
                Console.WriteLine("Can't refuel more than Fuel Capacity");
                return FuelCapacity;
            }
        }
    }
}
