using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsuptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsuptionPerKilometer = fuelConsumptionPerKilometer;

            TravelledDistance = 0;
        }

        public void Drive(double km)
        {
            var neededFuel = FuelConsuptionPerKilometer * km;

            if (neededFuel <= FuelAmount)
            {
                FuelAmount -= neededFuel;
                TravelledDistance += km;
            }
            else Console.WriteLine("Insufficient fuel for the drive");
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TravelledDistance}";
        }
    }
}
