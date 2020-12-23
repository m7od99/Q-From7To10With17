using System;
using System.Collections.Generic;
using System.Linq;

namespace newQuestions {
    public class Inversions {
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
                } 
                else i--;
            }
            // return the counter
            return counter;
        }
    }
}