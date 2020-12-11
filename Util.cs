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
            return new Random ().Next (10, 20);
        }
        public static int[] RandomIntArray () {
            var x = new int[LengthIntArray ()];
            for (int i = 0; i < x.Length; i++) {
                x[i] = new Random ().Next (0, 10000);
            }
            return x;
        }
    }
}