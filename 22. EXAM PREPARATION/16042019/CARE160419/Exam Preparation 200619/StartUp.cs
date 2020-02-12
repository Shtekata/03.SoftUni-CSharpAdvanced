
namespace Exam_Preparation_200619
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var numb = int.Parse(Console.ReadLine());

            var sparta = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var spartans = new Queue<int>(sparta);
            var spartan = spartans.Dequeue();
            var spartansNotEmpty = true;

            var warriors = new Stack<int>();
            var warrior = 0;

            for (int i = 1; i <= numb; i++)
            {
                var wafeWarriors = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (spartansNotEmpty)
                {
                    for (int j = 0; j < wafeWarriors.Length; j++)
                    {
                        warriors.Push(wafeWarriors[j]);
                    }
                    ;
                    if (i % 3 == 0)
                    {
                        var temp = int.Parse(Console.ReadLine());
                        spartans.Enqueue(temp);
                    }

                    for (int k = 0; k < wafeWarriors.Count(); k++)
                    {
                        if (spartan == 0 && spartans.Count > 0)
                        {
                            spartan = spartans.Dequeue();
                        }
                        else if (spartan == 0 && spartans.Count == 0)
                        {
                            spartansNotEmpty = false;
                            break;
                        }

                        if (warrior == 0 && warriors.Count > 0)
                        {
                            warrior = warriors.Pop();
                        }

                        if (warrior >= spartan)
                        {
                            warrior -= spartan;
                            spartan = 0;
                        }
                        else
                        {
                            spartan -= warrior;
                            warrior = 0;
                        }
                    }
                }
            }

            if (spartans.Count > 0 || spartan > 0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                if (spartan == 0)
                {
                    Console.WriteLine($"Plates left: {string.Join(", ", spartans)}");
                }
                else
                {
                    Console.WriteLine($"Plates left: {spartan}, {string.Join(", ", spartans)}");
                }
            }
            else
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                if (warrior == 0)
                {
                    Console.WriteLine($"Warriors left: {string.Join(", ", warriors)}");
                }
                else
                {
                    Console.WriteLine($"Warriors left: {warrior}, {string.Join(", ", warriors)}");
                }
            }
        }
    }
}
