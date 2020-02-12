using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    class SpaceStation
    {
        private List<Astronaut> astronauts;
        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            astronauts = new List<Astronaut>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => astronauts.Count;
        public void Add(Astronaut astronaut)
        {
            if (astronauts.Count < Capacity)
            {
                astronauts.Add(astronaut);
            }
        }
        public bool Remove(string name)
        {
            var astr = astronauts.Where(x => x.Name == name).FirstOrDefault();
            if (astr != null)
            {
                astronauts.Remove(astr);
                return true;
            }
            else return false;
        }
        public Astronaut GetOldestAstronaut()
        {
            var astr = astronauts.OrderByDescending(x => x.Age).FirstOrDefault();
            return astr;
        }
        public Astronaut GetAstronaut(string name)
        {
            var astr = astronauts.Where(x => x.Name == name).FirstOrDefault();
            return astr;
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {Name}:");
            foreach (var item in astronauts)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
