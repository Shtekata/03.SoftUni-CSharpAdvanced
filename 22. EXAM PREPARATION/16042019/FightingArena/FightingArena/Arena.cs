using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;
        public Arena(string name)
        {
            Name = name;
            gladiators = new List<Gladiator>();
        }
        public string Name { get; set; }
        public int Count => gladiators.Count;
        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }
        public void Remove(string name)
        {
            var gladiator = gladiators.Where(x => x.Name == name).FirstOrDefault();
            gladiators.Remove(gladiator);
        }
        public Gladiator GetGladitorWithHighestStatPower()
        {
            var gladiator = gladiators.OrderByDescending(x => x.GetStatPower()).FirstOrDefault();
            return gladiator;
        }
        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            var gladiator = gladiators.OrderByDescending(x => x.GetWeaponPower()).FirstOrDefault();
            return gladiator;
        }
        public Gladiator GetGladitorWithHighestTotalPower()
        {
            var gladiator = gladiators.OrderByDescending(x => x.GetTotalPower()).FirstOrDefault();
            return gladiator;
        }
        public override string ToString()
        {
            return $"[{Name}] - [{Count}] gladiators are participating.";
        }
    }
}
