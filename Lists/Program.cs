//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

Console.WriteLine("Hello, Lists!");

//* 1. Write a static method to find the sum of all the even numbers in a List.
static int sumEven(List<int> arr)
{
    int total = 0;
    foreach(int integer in arr)
    {
        if (integer % 2 == 0)
        {
            total += integer;
        }
    }
    return total;
}

//* 2. Create a list with at least 10 integers and call your method on the list.
List<int> numList = new List<int>(10);
numList.Add(1);
numList.Add(2);
numList.Add(3);
numList.Add(4);
numList.Add(5);
numList.Add(6);
numList.Add(7);
numList.Add(8);
numList.Add(9);
numList.Add(10);
Console.WriteLine("This is the sum of all the numbers in the list:");
Console.WriteLine(sumEven(numList));

//* 3. Write a static method to print out each word in a list that has exactly 5 letters.
static void fiveLetterWords(List<string> wordlist)
{
    foreach (string word in wordlist)
    {
        if (word.Length == 5)
        {
            Console.WriteLine(word);
        }
    }
}

List<string> wordlist = new List<string>(5);
wordlist.Add("dog");
wordlist.Add("house");
wordlist.Add("chair");
wordlist.Add("bear");
wordlist.Add("boat");

//* 4. Modify your code to prompt the user to enter the word length for the search.
Console.WriteLine("Enter a word length: ");
string wordLengthInput = Console.ReadLine();
int numChars = int.Parse(wordLengthInput);
    //Calling the method to print list of words of the chosen length:
    printXLetterWords(wordlist, numChars);

    static void printXLetterWords(List<string> wordlist, int length)
    {
        foreach (string word in wordlist)
        {
            if (word.Length == length)
            {
                Console.WriteLine(word);
            }
        }
    }
