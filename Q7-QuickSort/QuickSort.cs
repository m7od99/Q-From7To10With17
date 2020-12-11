using System;
using System.Collections.Generic;
using System.Linq;

namespace newQuestions
{
    public class QuickSort
    {
        //         -Quicksort: (A, n)
        public static int[] Sort(int[] A)
        {
            // 1- If  size (A) = 2 :   
            //  -Compare and fix order
            //  -return A
            if (A.Length < 2)
            {
                return A;
            }

            // 2-  pick some element in A (call it k)
            var k = A[0];

            // 3- make 2 lists  B and C
            var B = SmallerThen(A , k);
            var C = BiggerThen(A ,k);

            // -4 Sort(B) , Sort(C) .
            B = Sort(B);
            C = Sort(C);

            // 5- modify A .
            A = Modify(B , C ,k);
            // 6- return A .
            return A;
        }

        public static int[] SmallerThen(int[] numbers , int k)
        {
            var x = 0;
            var smaller = new List<int>();
            foreach(var number in numbers)
            {
                if (number < k)
                {
                    smaller.Add(number);
                }
                else if (number == k)
                {
                    x++;
                    if (x > 1)
                    {
                        smaller.Add(k);
                        x--;
                    }
                }
            }
            return smaller.ToArray();
        }
          public static int[] BiggerThen(int[] numbers , int k)
        {
            var Bigger = new List<int>();
            foreach(var number in numbers)
            {
                if (number > k)
                {
                    Bigger.Add(number);
                }
            }
            return Bigger.ToArray();
        }

        public static int[] Modify(int[] smaller , int[] bigger , int k)
        {
            var A = new List<int>();
            for (int i = 0; i < smaller.Length; i++)
            {
                A.Add(smaller[i]) ;
            }
            A.Add(k);
            for (int d = 0; d < bigger.Length; d++)
            {
                A.Add(bigger[d]);
            }
            return A.ToArray();
        }

    }

}