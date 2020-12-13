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
                Console.Write (Util.TestIsSummation ()+" "); // true
            }

        }

    }

}