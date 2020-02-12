namespace Heroes
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            var repository = new HeroRepository();

            var item = new Item(23, 35, 48);
            var secondItem = new Item(100, 20, 13);

            var hero = new Hero("Hero name", 24, item);
            var secondHero = new Hero("Second Hero Name", 125, secondItem);

            repository.Add(hero);
            repository.Add(secondHero);

            var heroStrength = repository.GetHeroWithHighestStrength();
            var heroAbility = repository.GetHeroWithHighestAbility();
            var heroIntelligence = repository.GetHeroWithHighestIntelligence();

            //Console.WriteLine(heroStrength);
            //Console.WriteLine(heroAbility);
            //Console.WriteLine(heroIntelligence);

            Console.WriteLine(repository.Count);

            Console.WriteLine(repository);
        }
    }
}
