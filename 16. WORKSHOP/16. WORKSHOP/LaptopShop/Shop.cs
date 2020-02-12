using System;
using System.Collections.Generic;

namespace LaptopShop
{
    public class Shop
    {
        private Dictionary<string, List<Laptop>> laptops;

        public Shop()
        {
            laptops = new Dictionary<string, List<Laptop>>();
        }
        public int Count
            => laptops.Count;
        public void AddLaptop(Laptop laptop)
        {
            IfNullThrowExeption(laptop);

            if (!laptops.ContainsKey(laptop.Make))
            {
                laptops.Add(laptop.Make, new List<Laptop>());
            }

            laptops[laptop.Make].Add(laptop);

        }

        public bool RemoveLaptop(Laptop laptop)
        {
            IfNullThrowExeption(laptop);

            if (!laptops.ContainsKey(laptop.Make))
            {
                return false;
            }

            if (!laptops[laptop.Make].Contains(laptop))
            {
                return false;
            }

            var isRemove = laptops[laptop.Make].Remove(laptop);

            if (laptops[laptop.Make].Count == 0)
            {
                isRemove = laptops.Remove(laptop.Make);
            }

            return isRemove;
        }

        public bool ContainsLaptop(Laptop laptop)
        {
            IfNullThrowExeption(laptop);

            if (!laptops.ContainsKey(laptop.Make))
            {
                return false;
            }

            if (!laptops[laptop.Make].Contains(laptop))
            {
                return false;
            }

            return true;
        }

        public void PrintAllLaptops(Action<Laptop> action)
        {
            foreach (var (make, dictionaryLaptops) in laptops)
            {
                foreach (var laptop in dictionaryLaptops)
                {
                    action(laptop);
                }
            }
        }

        private void IfNullThrowExeption(Laptop laptop)
        {
            if (laptop == null)
            {
                throw new ArgumentNullException(nameof(laptop), "Object cannot be null!");
            }
        }
    }
}
