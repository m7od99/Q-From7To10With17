using System;
using System.Collections.Generic;
using System.Linq;

namespace newQuestions {

    public class Inversions {

        public int Amount { get; set; }
        public List<int> Sorted { get; set; }

        public static int NumberOfInversions (List<int> numbers) {
            //0-Initialize counter that count inversions . 
            var counter = 0;
            var i = numbers.Count - 1;
            // 0-inversions list named sortedList that copy input list . 
            var copyNumber = 0;
            // -First will cheak last two numbers in list if :
            while (i > 0) {
                if (numbers[i] < numbers[i - 1]) {
                    counter++;
                    copyNumber = numbers[i];
                    numbers[i] = numbers[i - 1];
                    numbers[i - 1] = copyNumber;
                    i = numbers.Count - 1;
                    continue;
                } else i--;
            }
            // return the counter
            return counter;
        }

        public static int CountInversion (List<int> numbers) {

            if (numbers.Count == 1) return 0;

            var mid = numbers.Count / 2;
            var left = new List<int> ();
            var right = new List<int> ();

            left = SplitLeft (numbers, left, mid);
            right = SplitRight (numbers, right, mid);

            var i = CountInversion (left) + CountInversion (right);

            left = MergeSorter.MergeSort (left.ToArray ()).ToList ();
            right = MergeSorter.MergeSort (right.ToArray ()).ToList ();

            return Count (left, right, i);
        }

        private static int Count (List<int> left, List<int> right, int i) {

            var x = 0;
            var y = 0;

            while (left.Count - 1 >= x && right.Count - 1 >= y)
             {
                if (left[x] <= right[y]) x++;

                else
                {
                    i = i + left.Count - x;
                    y++;
                }
            }
            return i;
        }

        public static List<int> SplitLeft (List<int> numbers, List<int> left, int midle) {
            var x = 0;
            while (x < midle) {
                left.Add (numbers[x]);
                x++;
            }
            return left;
        }
        public static List<int> SplitRight (List<int> numbers, List<int> right, int mid) {

            while (numbers.Count - 1 >= mid) {
                right.Add (numbers[mid]);
                mid++;
            }
            return right;
        }

    }
}