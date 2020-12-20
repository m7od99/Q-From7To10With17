using System;
using System.Collections.Generic;
using System.Linq;
namespace newQuestions {
    public class MergeSorter {

        // Part 1 : MergeSort() : (Split)
        public static int[] MergeSort (int[] numbers) {

            // 1-base case : when numbers size be 1 return number . 
            if (numbers.Length <= 1) {
                return numbers;
            }

            // 0-Initialize two list of int the first named left and second right . 
            var left = new List<int> ();
            var right = new List<int> ();

            // 0-Initialize midle numbers by divide numbers.size by 2 .
            var midle = numbers.Length / 2;
            // 2-the left list take every numbers until midle and the right take numbers after midle .
            left = SplitLeft (numbers, left, midle);
            right = SplitRight (numbers, right, midle);

            // 3-left = MargeSort(left) , right = MergrSort(right) .
            left = MergeSort (left.ToArray ()).ToList ();
            right = MergeSort (right.ToArray ()).ToList ();

            // 4-return Marge(left , right) .
            return Merge (left, right);
        }

        // Part 2 : Merge()
        public static int[] Merge (List<int> left, List<int> right) {

            // 0-Initialize  list of int named numbers to put the sorted numbers in it .
            List<int> numbers = new List<int> ();

            // 1-while left and right not empty compere the first of both the smaller will add to numbers and remove it from left or right . 
            var x = 0;
            var y = 0;
            while (left.Count - 1 >= x && right.Count - 1 >= y) {
                if (left[x] <= right[y]) {
                    numbers.Add (left[x]);
                    x++;
                } else {
                    numbers.Add (right[y]);
                    y++;
                }
            }

            // 2-if one of them empty and other not put then in numbers . 
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
            // 3-return numbers .
            return numbers.ToArray ();
        }

        public static List<int> SplitLeft (int[] numbers, List<int> left, int midle) {
            var x = 0;
            while (x < midle) {
                left.Add (numbers[x]);
                x++;
            }
            return left;
        }

        public static List<int> SplitRight (int[] numbers, List<int> right, int mid) {

            while (numbers.Length - 1 >= mid) {
                right.Add (numbers[mid]);
                mid++;
            }
            return right;
        }

    }
}