using System;
using System.Collections.Generic;
using System.Linq;

namespace newQuestions {

    public class Inversions {

        public int Amount { get; set; }
        public List<int> Sorted { get; set; }

        public static int NumberOfInversions (List<int> number) {
            var numbers = CopyList (number);
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

        //Part 1 : CountInversion() *Split*
        public static int CountInversion (List<int> numbers) {
            //base case 
            if (numbers.Count == 1) return 0;

            //creat int midle , list left and right .
            var mid = numbers.Count / 2;
            var left = new List<int> ();
            var right = new List<int> ();

            //left is input list until midle and right is numbers after midle .
            left = SplitLeft (numbers, left, mid);
            right = SplitRight (numbers, right, mid);

            //Initialize int counter that equle CountInversion(left) + CountInversion(right).
            var counter = CountInversion (left) + CountInversion (right);

            //sort left and right .
            left = MergeSorter.MergeSort (left.ToArray ()).ToList ();
            right = MergeSorter.MergeSort (right.ToArray ()).ToList ();

            // return count(left , right , counter).
            return Count (left, right, counter);
        }

        //Part 2 : Count().
        public static int Count (List<int> left, List<int> right, int counter) {
            //creat int x and y .
            var x = 0;
            var y = 0;

            //while left and right not empty compere them .
            while (left.Count - 1 >= x && right.Count - 1 >= y) {
                //if right smaller then left counter = counter + left.size - x .  
                if (right[y] < left[x]) {
                    counter = counter + left.Count - x;
                    y++;
                } else x++;
            }

            //return counter .
            return counter;
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
        public static List<int> CopyList (List<int> numbers) {
            var copy = new List<int> ();
            foreach (var num in numbers) {
                copy.Add (num);
            }
            return copy;
        }

    }
}