using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    class Restaurant
    {
        private List<Salad> salads;
        public Restaurant(string name)
        {
            Name = name;
            salads = new List<Salad>();
        }
        public string Name { get; set; }
        public void Add(Salad salad)
        {
            salads.Add(salad);
        }
        public bool Buy(string name)
        {
            var salad = salads.Where(x => x.Name == name).FirstOrDefault();
            if (salad != null)
            {
                return true;
            }
            else return false;
        }
        public string GetHealthiestSalad()
        {
            var salad = salads.OrderBy(x => x.GetTotalCalories()).First();
            return salad.Name;
        }
        public string GenerateMenu()
        {
            var output = $"{Name} have {salads.Count} salads:"
                + Environment.NewLine
                + string.Join("\n", salads);
            return output;
        }
    }
}
