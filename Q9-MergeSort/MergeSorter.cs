using System;
using System.Collections.Generic;
using System.Linq;
namespace newQuestions {
    public class MergeSorter {

        // Part 1 : MergeSort() : (Split)
        public static int[] MergeSort (int[] numbers) {

            // 1-base case : when numbers size be 1 return number . 

            // 0-Initialize two list of int the first named left and second right . 

            // 0-Initialize midle numbers by divide numbers.size by 2 .

            // 2-the left list take every numbers until midle and the right take numbers after midle .

            // 3-left = MargeSort(left) , right = MergrSort(right) .

            // 4-return Marge(left , right) .
        }

        // Part 2 : Merge()
        public static int[] Merge (List<int> left, List<int> right) {

            // 0-Initialize  list of int named numbers to put the sorted numbers in it .

            // 1-while left and right not empty compere the first of both the smaller will add to numbers and remove it from left or right . 

            // 2-if one of them empty and other not put then in numbers . 

            // 3-return numbers .
        }

    }
}