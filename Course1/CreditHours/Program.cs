// See https://aka.ms/new-console-template for more information
Console.Write("Enter Student Name:  ");

//Fetching Student Name
string? studentName = Console.ReadLine();

while (string.IsNullOrEmpty(studentName))
{
    Console.WriteLine("No name entered. Please provide the name");
    studentName = Console.ReadLine();
}

//Initializing variables
string[] courseNames = ["English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101" ];
int[] grade = [ 4, 3, 3, 3, 4 ];
int[] creditHours = [ 3, 3, 4, 4, 3 ];

int totalCredits = 0;
int totalCreditHours = 0;
decimal creditPoint;
string creditPointFormatted = "";

//Calculating Credit Points
for(int iteration = 0; iteration < grade.Length; iteration ++)
{
    totalCredits += grade[iteration] * creditHours[iteration];
    totalCreditHours += creditHours[iteration];
}

creditPoint = (decimal)totalCredits / totalCreditHours;
//creditPointFormatted = String.Format("{0:0.00}", creditPoint);
creditPointFormatted = creditPoint.ToString("F"); //or ("#.##") 
//to specify exact decimal points mention as F2, F3. Default = 2
// use ("C") for currency and 2 decimal points but it is giving ?


/*
-- Another method for creditPointFormatting
    int leadingDigit = (int) creditPoint;
    int firstDigit = (int) (creditPoint * 10) % 10;
    int secondDigit = (int) (creditPoint * 100 ) % 10;
    Console.WriteLine($"\nFinal GPA: {leadingDigit}.{firstDigit}{secondDigit}");
*/

//Printing the result
Console.WriteLine($"\nStudent: {studentName}\n\nCourse\t\t\tGrade  Credit Hours");
for(int printCount = 0; printCount < courseNames.Length; printCount ++)
{
    if(courseNames[printCount].Contains("Computer") == true)
        Console.WriteLine("{0}\t{1}\t{2}", courseNames[printCount], grade[printCount], creditHours[printCount]);
    else
        Console.WriteLine("{0}\t\t{1}\t{2}", courseNames[printCount], grade[printCount], creditHours[printCount]);
}

Console.WriteLine($"Final GPA:\t\t{creditPointFormatted}");