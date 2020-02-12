using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public static class ArrayCreator
    {
        public static T[] Create<T>(int l,T element)
        {
            T[] array = new T[l];
            for (int i = 0; i < l; i++)
            {
                array[i] = element;
            }
            return array;
        }
    }
}
