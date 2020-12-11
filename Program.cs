using System;
using System.Linq;
using System.Collections.Generic;

namespace newQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = {50,45,30,1,10,100,56,50,50};
            var c =QuickSort.Sort(d); // 
            foreach(var item in c)
            {
                Console.WriteLine(item);
            }
        }

    }
    
}
