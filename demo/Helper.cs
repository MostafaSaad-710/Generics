using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Helper
    {

        // Generic Constraints:
        // 1. Primary Constraints [0 : 1]
        //  1.1. class
        //  1.1. struct
        //  1.1. special type point
        //  1.1. enum
        //  1.1. notnull

        // 2. Secondary Constraints [0 : M]
        //  T Implement Interface

        // 3. Constructor Constraints

        //  T : Must Be Type Which Implement The ICompareable Interface
        //Generic SWAP
        public static void SWAP<T>(ref T X ,ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        //Generic LinearSearch
        public static int LinearSearch<T>(T[] arr, T value)
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(value))
                        return i;
                }
            }
            return -1;
        }

        public static int LinearSearch<T>(T[] arr, T value , IEqualityComparer<T> equalityComparer)
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (equalityComparer.Equals(arr[i] , value))
                        return i;
                }
            }
            return -1;
        }

        //Generic Bubble Sort
        public static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
           if(arr?.Length > 0)
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j+1]) > 0)
                            SWAP(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        public static void BubbleSort<T>(T[] arr , IComparer<T> comparer ) where T : IComparable<T>
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (comparer.Compare(arr[j], arr[j + 1]) > 0)
                            SWAP(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }






        public static void PrintArray<T>(T[] arr)
        {
            foreach(T item in arr)
            {
                Console.WriteLine($"{item} , ");
            }
            Console.WriteLine( );
        }




    }
}
