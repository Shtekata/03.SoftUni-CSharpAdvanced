using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository : IEnumerable<Hero>
    {
        private Hero hero;
        private Dictionary<string, Hero> repository;

        public HeroRepository()
        {
            repository = new Dictionary<string, Hero>();
        }

        public int Count
        {
            get
            {
                return repository.Count();
            }
        }
        public void Add(Hero hero)
        {
            repository.Add(hero.Name, hero);
        }

        public void Remove(string heroName)
        {
            if (repository.ContainsKey(heroName))
            {
                repository.Remove(heroName);
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            var sortedItem = repository.OrderByDescending(x => x.Value.Item.Strength).FirstOrDefault().Value;

            return sortedItem;
        }

        public Hero GetHeroWithHighestAbility()
        {
            var sortedItem = repository.OrderByDescending(x => x.Value.Item.Ability).FirstOrDefault().Value;

            return sortedItem;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            var sortedItem = repository.OrderByDescending(x => x.Value.Item.Intelligence).FirstOrDefault().Value;

            return sortedItem;
        }

        public IEnumerator<Hero> GetEnumerator()
        {
            foreach (var item in repository)
            {
                yield return item.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in repository)
            {
                sb.AppendLine(item.Value.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
