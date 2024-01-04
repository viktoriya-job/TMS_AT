using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Generics
{
    internal class ArrayGeneric<T>
    {
        public int Length { get; set; }
        public T[] ArrayValues { get; set; }

        public ArrayGeneric(int length)
        {
            Length = length;
            ArrayValues = new T[length];
        }

        public void Add(T value)
        {
            Length++;
            var tmp = new List<T>(ArrayValues);
            tmp.Add(value);
            ArrayValues = tmp.ToArray();
        }

        public void Remove(T value)
        {
            if (Array.IndexOf(ArrayValues, value) > -1)
            {
                var tmp = new List<T>(ArrayValues);
                tmp.RemoveAll(element => element.Equals(value));
                Length = tmp.Count;
                ArrayValues = tmp.ToArray();
            }
        }

        public T GetByIndex(int index)
        {
            return ArrayValues[index];
        }

        public int GetLenth()
        {
            return Length;
        }
    }
}
