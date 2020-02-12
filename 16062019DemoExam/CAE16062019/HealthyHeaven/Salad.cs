using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    class Salad
    {
        private List<Vegetable> vegetables;
        public Salad(string name)
        {
            vegetables = new List<Vegetable>();
            Name = name;
        }
        public string Name { get; set; }
        public int GetTotalCalories()
        {
            var sum = vegetables.Sum(x => x.Calories);
            return sum;
        }
        public int GetProductCount()
        {
            var productCount = vegetables.Count;
            return productCount;
        }
        public void Add(Vegetable vegetable)
        {
            vegetables.Add(vegetable);
        }
        public override string ToString()
        {
            var output = $"* Salad {Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:"
                +Environment.NewLine 
                +string.Join("\n", vegetables);
            return output;
        }
    }
}
