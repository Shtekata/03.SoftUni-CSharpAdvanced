using System;
using System.Collections.Generic;
using System.Linq;

namespace Gredy
{
    class Program
    {
        static void Main(string[] args)
        {
            var coins = new int[] { 10, 10, 10, 5, 5, 2, 5, 1, 1, 1, 2 };

            coins = coins
                .OrderByDescending(x => x)
                .ToArray();

            var target = int.Parse(Console.ReadLine());
            var current = 0;
            var sum = 0;
            var result = new Dictionary<int, int>();

            //var result = new List<int>();

            //while (sum < target)
            //{
            //    if (sum + coins[current] > target)
            //    {
            //        current++;
            //    }
            //    else
            //    {
            //        sum += coins[current];
            //        result.Add(coins[current]);
            //    }
            //    if (current == coins.Length)
            //    {
            //        throw new Exception("No solution found!");
            //    }
            //}

            for (int i = 0; i < coins.Length; i++)
            {
                if (sum + coins[i] > target)
                {
                    continue;
                }
                sum += coins[i];

                if (!result.ContainsKey(coins[i]))
                {
                    result.Add(coins[i], 0);
                }

                result[coins[i]]++;

                if (sum == target)
                {
                    break;
                }

            }

            if (target != sum)
            {
                Console.WriteLine("No solution found!");
            }
            else
            {
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Value} x {item.Key}");
                }
            }
        }
    }
}
