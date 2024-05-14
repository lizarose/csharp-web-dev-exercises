//Exercises: Control Flow & Collections

//TODO: Write your code for Array Practice below:

Console.WriteLine("Hello, Arrays!");

//1. Create and initialize an array with the following values in a single line:
//  Use these values: 1, 1, 2, 3, 5, 8
Console.WriteLine("These are all of the numbers in the array:");
int [] array = new int [6];
array[0] = 1;
array[1] = 1;
array[2] = 2;
array[3] = 3;
array[4] = 5;
array[5] = 8;
//2. Loop through the array and print out each value.
foreach(int num in array)
{
    Console.WriteLine(num);
}

Console.WriteLine("\n");
//3. Modify the loop to only print the odd numbers from the array.
Console.WriteLine("These are the odd numbers in the array:");
foreach(int num in array)
{
    if (num % 2 != 0)
    {
       Console.WriteLine(num); 
    }   
}

Console.WriteLine("\n");
Console.WriteLine("These are the even numbers in the array:");
foreach(int num in array)
{
    if (num % 2 == 0)
    {
       Console.WriteLine(num); 
    }   
}