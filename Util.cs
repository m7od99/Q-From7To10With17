using System;
using System.Collections.Generic;
namespace newQuestions {
    public class Util {
        public static bool TestIsSorted () {
            var x = RandomIntArray ();
            x = QuickSort.Sort (x);
            for (int i = x.Length - 1; i > 0; i--) {
                if (x[i] < x[i - 1]) {
                    return false;
                }
            }
            return true;
        }
        public static int LengthIntArray () {
            return new Random ().Next (1000, 10000);
        }
        public static int[] RandomIntArray () {
            var x = new int[LengthIntArray ()];
            for (int i = 0; i < x.Length; i++) {
                x[i] = new Random ().Next (-10000, 10000);
            }
            return x;
        }

        public static bool TestIsFactorial () {
            var x = new Random ().Next (1, 10000);
            var factorial = 1;
            for (int i = 1; i <= x; i++) {
                factorial = factorial * i;
            }
            if (Recursion.Factorial (x) != factorial) {
                return false;
            }
            return true;
        }
        public static bool TestIsSummation()
        {
            var x = new Random ().Next (1, 10000);
            var Summation = 0;
            for (int i = 0; i <= x; i++) {
                Summation = Summation + i;
            }
            if (Recursion.Summation (x) != Summation) {
                return false;
            }
            return true;
        }
    }
}