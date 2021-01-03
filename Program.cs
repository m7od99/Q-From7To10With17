using System;
using System.Collections.Generic;
using System.Linq;

namespace newQuestions {
    class Program {
        static void Main (string[] args) {
            for (int i = 0; i < 10; i++) { // test is sorted 
                Console.Write (Util.TestIsSorted () + " "); // true
            }

            Console.WriteLine ();

            for (int i = 0; i < 10; i++) // test factoraial
            {
                Console.Write (Util.TestIsFactorial () + " "); // true
            }

            Console.WriteLine ();

            for (int i = 0; i < 10; i++) { // test Summation
                Console.Write (Util.TestIsSummation () + " "); // true
            }

            Console.WriteLine ();

            for (int i = 0; i < 10; i++) {
                Console.Write (Util.TestIsEncoded () + " "); // true
            }
            Console.WriteLine ();

            for (int i = 0; i < 10; i++) {
                Console.Write (Util.TestIsFibonacci () + " "); // true
            }
            Console.WriteLine ();

            for (int i = 0; i < 10; i++)
            {
                Console.Write (Util.TestMergeSoet () + " "); // true
            }

            Console.WriteLine();
            var test = new List<int>() {3,2,1,6,9,0,10,5};
            Console.WriteLine(Inversions.NumberOfInversions(test));
           
        }
     
    }

}