using System;
using System.Collections.Generic;
using System.Linq;
namespace newQuestions {
    public class Util {
        //****************************************************************
        //test Q 7 quick sort 
        //****************************************************************
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
            return new Random ().Next (100, 500);
        }
        public static int[] RandomIntArray () {
            var x = new int[LengthIntArray ()];
            for (int i = 0; i < x.Length; i++) {
                x[i] = new Random ().Next (-10000, 10000);
            }
            return x;
        }
        //****************************************************************
        //test Q 8 recrsion  
        //****************************************************************

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
        public static bool TestIsSummation () {
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

        public static bool TestIsFibonacci () {
            var x = new Random ().Next (1, 20);
            if (Fibonacci (x) == Recursion.Fibonacci (x)) {
                return true;
            } else return false;
        }

        public static int Fibonacci (int number) {
            var x = 0;
            var y = 1;
            var result = 0;
            for (int i = 0; i <= number; i++) {
                result = result + x;
                x = y;
                y = result;
            }
            return result;
        }
        //**********************************************
        // Test Q9 merge sort
        //***********************************************
        public static bool TestMergeSoet () {
            var x = RandomIntArray ();
            x = MergeSorter.MergeSort (x);
            for (int i = x.Length - 1; i > 0; i--) {
                if (x[i] < x[i - 1]) {
                    return false;
                }
            }
            return true;
        }
        //****************************************************************
        //Test Q10 Inversions
        //****************************************************************
        public static bool TestInversions () {
            var numbers = RandomIntArray ().ToList ();
            numbers = MergeSorter.MergeSort (numbers.ToArray ()).ToList ();

            var i = new Random ().Next (1, 20);
            var x = numbers[0];
            numbers[i] = numbers[0];
            numbers[0] = x;

            if (Inversions.NumberOfInversions (numbers) == i - 1) return true;
            else return false;
        }
        public static bool TestCountInversions () {
            var numbers = RandomIntArray ().ToList ();

            if (Inversions.CountInversion (numbers) == Inversions.NumberOfInversions (numbers)) {
                return true;
            }
            return false;
        }

        //****************************************************************
        // test Q 17 encoder 
        //****************************************************************
        public static bool TestIsEncoded () {
            var x = new Random ().Next (100, 1000).ToString ();
            var xX = Encoder.EnCoder (x);
            if (x != Encoder.DeCoder (xX)) {
                return false;
            }
            return true;
        }

    }
}