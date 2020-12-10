a sort method that use recursion .






input : int array 

output : return a sorted array







-Quicksort: (A, n)

1- If  size (A) = 2 :   
          Compare and fix order
          return A
 
2-  pick some element in A (call it k)

3- make 2 lists  B and C

      - B has the elements in A smaller      
        than k.
  
      - C has the elements in A bigger
        than k

 4-  set:
        B  =  Quicksort ( B)
        C = Quicksort (C)

5-  modify A
        -  empty A
       -  First insert B
       - then insert k
       - then  insert  C

6-   return A