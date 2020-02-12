using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExercise
{
   public class Threeuple<T1,T2,T3>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Item1} -> {Item2} -> {Item3}");
        }
    }
}
