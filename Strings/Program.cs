//*Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

Console.WriteLine("Hello, Strings!");

//*1. For this exercise, create a string for the value:
    //I would not, could not, in a box. I would not, could not with a fox.
    //I will not eat them in a house. I will not eat them with a mouse.

string phrase = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

//*2. Use the Split method to divide the string at each space and store the individual words in an array. If you need to review the method syntax, look back at the string methods table.
string[] words = phrase.Split(" ");

//*3. Print the array of words to verify that your code works.
Console.WriteLine(string.Join(",", words));

//*4. Repeat steps 2 and 3, but change the delimiter to split the string into separate sentences.
Console.WriteLine("\n");

string[] sentences = phrase.Split(".");
Console.WriteLine(string.Join(",", sentences));