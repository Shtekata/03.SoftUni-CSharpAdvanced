using System;

namespace CustomStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new CustomList();
            //var list2 = new CustomList(50);
            //
            //list.Add(7);
            //list.Add(12);
            //list.Add(23);
            //
            //list.AddRange(new int[] { 3, 56, 45, 8, 9, 67, 23, 34 });
            //list.RemoveAt(3);
            ////list.InsertAt(1456, 90);
            //list.InsertAt(4, 8);
            //list.Swap(0, 8);
            //
            //list.ForEach(Console.Write);

            var st = new CustomStack();
            st.Push(6);
            st.Push(7);
            st.Push(8);
            st.Push(9);

            var x = st.Pop();
            st.Push(89);
            st.Push(345);

            x = st.Peek();

            st.ForEach(Console.WriteLine);
        }
    }
}
