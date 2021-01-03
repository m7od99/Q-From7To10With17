programt that  given a list of numbers, return the number of inversions required in order to sort the list.






-input : list of numbers . 

-output : the number of inversions required in order to sort the list.




0-Initialize counter that count inversions . 

0-inversions list named sortedList that copy input list . 



-First will cheak last two numbers in list if the last one bigger then the previous will move from last to cheak other two numbers until reach the first number from the list . 


-if the last one not bigger then the previous : 
          -counter = counter+ 1 . 
          -sortedList[i] = inputList[i-1] . ( i == index of number)
          -inputList[i-1] = inputList[i] . (this two steps to inversions thier position)
          -inputList = sortedList  . 
          -stop the loop and start from beginning . 


return the counter . 

*****************************************************************************************************************

-n log n answer : 





-input : list of numbers . 

-output : the number of inversions required in order to sort the list.




**Part 1 : CountInversion() *Split*



-base case : -if size of list is 1 return 0 . // 


0-Initialize two list left and right . 

0-Initialize midle numbers by divide numbers.size by 2 . 

0-the left list take every numbers until midle and the right take numbers after midle .

0-Initialize i = CountInversion(left) + CountInversion(right). // thats to reach base case .



-we will count evrey time thats right smaller then left until the list be sorted to do that :
                    -first sort left and right .
                    -second we will use method that count it ,return Count(left , right , i) . 






**part2 : Count()*


0-Initialize x for index of left at 0 and y index of right at 0 .


-while left and right not empty we will compere left and right 
            -if right(y) smaller then left(x)
            -becuse we know the left and right is sorted thats mean the first index of both is smallest in them 
            and thats mean if the right smaller then left thats right number smaller then every element in 
            left until the index of (x) => i = i + (left.size - x) .

            
-return i . 