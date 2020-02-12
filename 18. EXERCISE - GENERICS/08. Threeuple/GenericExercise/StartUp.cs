
namespace GenericExercise
{
    using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            var input1 = Console.ReadLine()
                .Split();
            var in1Name = $"{input1[0]} {input1[1]}";
            var in1Adress = input1[2];
            var in1City = string.Empty;
            if (input1.Length == 5)
            {
                in1City = $"{input1[3]} {input1[4]}";
            }
            else in1City = input1[3];
            var in1Three = new Threeuple<string, string, string>();
            in1Three.Item1 = in1Name;
            in1Three.Item2 = in1Adress;
            in1Three.Item3 = in1City;

            var input2 = Console.ReadLine()
                .Split();
            var in2Name = input2[0];
            var in2Count = int.Parse(input2[1]);
            bool in2Bool;
            if (input2[2] == "drunk")
            {
                in2Bool = true;
            }
            else
            {
                in2Bool = false;
            }
            var in2Three = new Threeuple<string, int, bool>();
            in2Three.Item1 = in2Name;
            in2Three.Item2 = in2Count;
            in2Three.Item3 = in2Bool;

            var input3 = Console.ReadLine()
                .Split();
            var in3Name = input3[0];
            var in3BankBal = double.Parse(input3[1]);
            var in3Bank = input3[2];
            var in3Three = new Threeuple<string, double, string>();
            in3Three.Item1 = in3Name;
            in3Three.Item2 = in3BankBal;
            in3Three.Item3 = in3Bank;

            in1Three.Print();
            in2Three.Print();
            in3Three.Print();
        }
    }
}
