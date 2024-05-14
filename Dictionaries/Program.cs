//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:

Console.WriteLine("Hello, Dictionary!");

//* 1. Make a program similar to GradebookDictionary that does the following:
//*    -It takes in student names and ID numbers (as integers) instead of names and grades.
Dictionary<string, int> students = new Dictionary<string, int>();
string newStudent;
int newID;
Console.WriteLine("Enter your students' names and their ID numbers: ");

    //do-while loop to keep adding in students
    do
    {
        Console.WriteLine("Student Name: ");
        string input = Console.ReadLine();
        newStudent = input;

        if (!Equals(newStudent, "")) {
            Console.WriteLine("ID: ");
            newID = int.Parse(Console.ReadLine());
            students.Add(newStudent, newID);

            Console.ReadLine();
        }
    } while (!Equals(newStudent, ""));





        // if (newStudent != "")
        // {
        //     Console.WriteLine("ID Number: ");
        //     newID = int.Parse(Console.ReadLine());
        //     students.Add(newStudent, newID);
        // }
//*    -The keys should be the IDs and the values should be the names.
    Console.WriteLine("\nClass Roster: ");

    foreach (KeyValuePair<string, int> student in students)
    {
        Console.WriteLine(student.Key + "'s ID: " + student.Value);
    }
    Console.WriteLine("Number of students in roster: " + students.Count);

//*    -Modify the roster printing code accordingly.