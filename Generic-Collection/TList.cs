using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Collection
{
    public class TList<T>
    {
        private T[] arr;


        public TList()
        {
            arr = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = data;
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }




    }
}

