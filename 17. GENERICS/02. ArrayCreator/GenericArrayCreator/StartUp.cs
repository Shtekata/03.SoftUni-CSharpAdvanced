using System;

namespace GenericArrayCreator
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string[] newArray = ArrayCreator.Create(5, "Pesho");
            int[] inter = ArrayCreator.Create(4, 33);
        }
    }
}
