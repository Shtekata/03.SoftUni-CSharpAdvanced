
namespace _09._Simple_Text_Editor
{
using System;
    using System.Collections.Generic;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            var stackOfText = new Stack<string>();
            var tempString = new StringBuilder();
            var operations = int.Parse(Console.ReadLine());

            for (int i = 0; i < operations; i++)
            {
                var command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "1")
                {
                    stackOfText.Push(tempString.ToString());
                    tempString.Append(command[1]);
                }
                else if (command[0] == "2")
                {
                    stackOfText.Push(tempString.ToString());
                    var length = int.Parse(command[1]);
                    tempString.Remove(tempString.Length - length, length);
                }
                else if (command[0] == "3")
                {
                    var index = int.Parse(command[1]) - 1;
                    Console.WriteLine(tempString[index]);
                }
                else if (command[0] == "4")
                {
                    tempString.Clear();
                    tempString.Append(stackOfText.Pop());
                }
            }
        }
    }
}
