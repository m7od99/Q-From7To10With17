using System;
using System.Collections.Generic;
using System.Linq;

namespace newQuestions {
    public class TestInversions : Inversions {
        public static List<int> RandomSortedList () {
            var numbers = new List<int> ();
            var x = new Random ().Next (4, 10);

            for (int i = 0; i <= x; i++) {
                numbers.Add (new Random ().Next (0, 100));
            }
            return MergeSorter.MergeSort (numbers.ToArray ()).ToList ();
        }

        public static List<int> DoInversions (List<int> numbers) {
            if (numbers.Count == 1) {
                return numbers;
            }

            //
            var mid = numbers.Count / 2;
            var left = new List<int> ();
            var right = new List<int> ();

            //
            left = SplitLeft (numbers, left, mid);
            right = SplitRight (numbers, right, mid);

            //
            left = DoInversions (left);
            right = DoInversions (right);

            return MakeInv (left, right);
        }

        private static List<int> MakeInv (List<int> left, List<int> right) {
            List<int> numbers = new List<int> ();
            var x = 0;
            var y = 0;
            var counter = 0;
            var rNum = new Random ().Next (0, left.Count + right.Count - 1);
            while (rNum >= counter && counter > 0) {
                if (left.Count - 1 >= x && right.Count - 1 >= y) {
                    numbers.Add (right[y]);
                    counter ++;
                    y++;
                }

            }
            while (left.Count - 1 >= x && right.Count - 1 >= y) {
                if (left[x] <= right[y]) {
                    numbers.Add (left[x]);
                    x++;
                } else {
                    numbers.Add (right[y]);
                    y++;
                }
            }

            if (left.Count - 1 >= x && right.Count - 1 < y) {
                while (left.Count - 1 >= x) {
                    numbers.Add (left[x]);
                    x++;
                }
            } else {
                while (right.Count - 1 >= y) {
                    numbers.Add (right[y]);
                    y++;
                }
            }

            return numbers;
        }

        public static int TCountInv (List<int> numbers) {
            if (numbers.Count == 1) {
                return 0;
            }

            //
            var mid = numbers.Count / 2;
            var left = new List<int> ();
            var right = new List<int> ();

            //
            left = SplitLeft (numbers, left, mid);
            right = SplitRight (numbers, right, mid);

            //
            var count = TCountInv (left) + TCountInv (right);

            //
            left = DoInversions (left);
            right = DoInversions (right);
            
            return Count (left, right, count);
        }
        public static bool TestIsRight()
        {
            var numbers = RandomSortedList();
            var change= DoInversions(numbers);

            if (TCountInv(change) != CountInversion(change))
            {
                return false;
            }
             return true;
        }
    }
}