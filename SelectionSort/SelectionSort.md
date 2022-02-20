## Selection Sort

Selection sort is a **sorting algorithm** that selects the smallest element from an unsorted list in easch iteration and places that element at the beginning of the unsorted list.


----


1. Set the first element as <ins>minimum</ins>.

   [<mark>**20**</mark>,12,10,15,2]
   
---

2. Compare  minimum with the second element.If the second element is smaller than *minimum*, assign the second element as *minimum*.

   Compare *minimum* with the third element .Again, if the third element is smaller, then assign *minimum* to the third element otherwise do nothing.The process goes on unti the last element.

   [20,<mark>**12**</mark>,10,15,2]

   [20,12,<mark>**10**</mark>,15,2]

   [20,12,10,15,<mark>**2**</mark>]

3. After each iteration, *minimum* is placed in front of the unsorted list

   [<mark>**2**</mark>,12,10,15,20]

4.For each iteration, indexing starts from the first unsorted element.Step 1 to 3 are repeated until all the elements are placed at their correct positions.

### Selection Sort Algorithm
-SelectionSort(array, size)<br>
-repeat(size-1 times)<br>
-set the first unsorted element as the minimum<br>
-for each of unsorted elements<br>
-if element "<"Current minimum <br>
-set element as new minimum<br>
-Swap minimum with the first unsorted position <br>
-end selection sort<br>
