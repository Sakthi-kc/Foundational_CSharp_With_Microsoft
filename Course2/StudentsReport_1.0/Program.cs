// See https://aka.ms/new-console-template for more information

//Initializing variables
int examAssignments = 5;
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] sophiaScores = [ 90, 86, 87, 98, 100, 94, 90 ];
int[] andrewScores = [ 92, 89, 81, 96, 90, 89 ];
int[] emmaScores = [ 90, 85, 87, 98, 68,89, 89, 89 ];
int[] loganScores = [ 90, 95, 87, 88, 96, 96 ];
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

string currentStudent = "", currentLetterGrade = "";
int[] currentScores;

//Calculate Grade for the students
Console.WriteLine("Student\t\tGrade");
foreach (string name in studentNames)
{
    currentStudent = name;

    //Assigning student scores
    if( currentStudent == "Sophia")
        currentScores = sophiaScores;
    else if( currentStudent == "Andrew")
        currentScores = andrewScores;
    else if(currentStudent == "Emma")
        currentScores = emmaScores;
    else if(currentStudent == "Logan")
        currentScores = loganScores;
    else if (currentStudent == "Becky")
        currentScores = beckyScores;
    else if (currentStudent == "Chris")
        currentScores = chrisScores;
    else if (currentStudent == "Eric")
        currentScores = ericScores;
    else if (currentStudent == "Gregor")
        currentScores = gregorScores;
    else
        continue;

    //Calculate extra credit and sum it all to find grade
    int gradedAssignments = 0, currentScore = 0;
    decimal currentGradeValue = 0;
    foreach (int score in currentScores)
    {
        gradedAssignments += 1;
        if(gradedAssignments <= examAssignments)
            currentScore += score;
        else
            currentScore += score/ 10; //10% of each credit score to total
    }
    currentGradeValue = (decimal)currentScore / examAssignments;
    
    //Assign letter grade
    if (currentGradeValue >= 97)
        currentLetterGrade = "A+";

    else if (currentGradeValue >= 93)
        currentLetterGrade = "A";

    else if (currentGradeValue >= 90)
        currentLetterGrade = "A-";

    else if (currentGradeValue >= 87)
        currentLetterGrade = "B+";

    else if (currentGradeValue >= 83)
        currentLetterGrade = "B";

    else if (currentGradeValue >= 80)
        currentLetterGrade = "B-";

    else if (currentGradeValue >= 77)
        currentLetterGrade = "C+";

    else if (currentGradeValue >= 73)
        currentLetterGrade = "C";

    else if (currentGradeValue >= 70)
        currentLetterGrade = "C-";

    else if (currentGradeValue >= 67)
        currentLetterGrade = "D+";

    else if (currentGradeValue >= 63)
        currentLetterGrade = "D";

    else if (currentGradeValue >= 60)
        currentLetterGrade = "D-";

    else
        currentLetterGrade = "F";

    //Printing the result
    Console.WriteLine($"{currentStudent}\t\t{currentGradeValue}\t{currentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();