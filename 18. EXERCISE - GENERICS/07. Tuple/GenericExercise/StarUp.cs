
namespace GenericExercise
{
    using System;
   public class StartUp
    {
       public static void Main(string[] args)
        {
            var input1 = Console.ReadLine()
                .Split();
            var input1Name = $"{input1[0]} {input1[1]}";
            var input1Adress = input1[2];
            var input1Tuple = new Tuple<string, string>(input1Name, input1Adress);
            input1Tuple.Print();

            var input2 = Console.ReadLine()
                .Split();
            var input2Name = input2[0];
            var input2Quantity = int.Parse(input2[1]);
            var input2Tuple = new Tuple<string, int>(input2Name, input2Quantity);
            input2Tuple.Print();

            var input3 = Console.ReadLine()
                .Split();
            var input3Int = int.Parse(input3[0]);
            var input3Double = double.Parse(input3[1]);
            var input3Tuple = new Tuple<int, double>(input3Int, input3Double);
            input3Tuple.Print();
        }
    }
}
