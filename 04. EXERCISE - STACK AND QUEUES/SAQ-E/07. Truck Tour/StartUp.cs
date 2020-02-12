
namespace _07._Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfPumps = int.Parse(Console.ReadLine());
            var petrolPumps = new Queue<int[]>();
            for (int i = 0; i < numberOfPumps; i++)
            {
                var petrolPump = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                petrolPumps.Enqueue(petrolPump);
            }
            var index = 0;
            var trueCircle = true;
            while (true)
            {
                var totalFuel = 0;
                foreach (var item in petrolPumps)
                {
                    var petrolAmound = item[0];
                    var distance = item[1];
                    totalFuel += petrolAmound - distance;
                    if (totalFuel < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }
                }
                if (index > petrolPumps.Count)
                {
                    trueCircle = false;
                    break;
                }
                if (totalFuel >= 0) break;
            }
            if (trueCircle) Console.WriteLine(index);
        }
    }
}
