using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
   public class Parking
    {
        private Dictionary<string,Car> cars;

        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;

            cars = new Dictionary<string, Car>();
        }

        public int Count => cars.Count;

        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (cars.Count == capacity)
            {
                return "Parking is full!";
            }
            cars.Add(car.RegistrationNumber, car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";

        }

        public string RemoveCar(string regNumber)
        {
            if (!cars.ContainsKey(regNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            cars.Remove(regNumber);
            return $"Successfully removed {regNumber}";
        }

        public Car GetCar(string regNum)
        {
            Car x = null;
            if (cars.ContainsKey(regNum))
            {
                return cars[regNum];
            }
            return x;
        }

        public void RemoveSetOfRegistrationNumber(List<string> regNumbers)
        {
            foreach (var item in regNumbers)
            {
                RemoveCar(item);
            }
        }
    }
}
