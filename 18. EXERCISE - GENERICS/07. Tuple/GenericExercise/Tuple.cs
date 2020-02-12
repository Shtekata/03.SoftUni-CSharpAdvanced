using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExercise
{
   public class Tuple<T1, T2>
    {
        private T1 item1;
        private T2 item2;

        public Tuple(T1 Item1, T2 Item2)
        {
            item1 = Item1;
            item2 = Item2;
        }

        public void Print()
        {
            Console.WriteLine($"{item1} -> {item2}"); 
        }
    }
}
