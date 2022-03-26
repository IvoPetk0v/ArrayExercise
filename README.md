# ArrayExercise
Learning Arrays


1.	Train
A train has an **n** number of wagons (integer, received as input).
On the next n lines, you will receive the number of people that are going to get on each wagon.
Print out the number of passengers in each wagon followed by the total number of passengers on the train.


2.	Common Elements
Create a program that prints out all common elements in two arrays. You have to compare the elements of the second array to the elements of the first.


3.	Zig-Zag Arrays
Create a program that creates 2 arrays. You will be given an integer n. On the next n lines, you will get 2 integers.
Form 2 new arrays in a zig-zag pattern as shown below.


4.	Array Rotation
Create a program that receives an array and several rotations that you have to perform. 
The rotations are done by moving the first element of the array from the front to the back. Print the resulting array.


5.	Top Integers
Create a program to find all the top integers in an array. A top integer is an integer that is greater than all the elements to its right.


6.	Equal Sums
Create a program that determines if an element exists in an array for which the sum of all elements to its left is equal to the sum of all elements to its right.
If there are no elements to the left or right, their sum is considered to be 0.
Print the index of the element that satisfies the condition or "no" if there is no such element.

7.	Max Sequence of Equal Elements
Create a program that finds the longest sequence of equal elements in an array of integers. 
If several equal sequences are present in the array, print out the leftmost one.


8.	Magic Sum
Create a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.


9.	*Kamino Factory
The clone factory in Kamino got another order to clone troops. But this time you are tasked to find the best DNA sequence to use in the production. 
You will receive the DNA length and until you receive the command "Clone them!" you will be receiving a DNA sequence of ones and zeroes, split by "!" (one or several).
You should select the sequence with the longest subsequence of ones.
If there are several sequences with the same length of the subsequence of ones, print the one with the leftmost starting index,
if there are several sequences with the same length and starting index, select the sequence with the greater sum of its elements.
After you receive the last command "Clone them!" you should print the collected information in the following format:
"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
"{DNA sequence, joined by space}"
Input / Constraints
•	The first line holds the length of the sequences – integer in the range [1…100];
•	On the next lines until you receive "Clone them!" you will be receiving sequences (at least one) of ones and zeroes, split by "!" (one or several).
 Output
The output should be printed on the console and consists of two lines in the following format:
"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
"{DNA sequence, joined by space}"

