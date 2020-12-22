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