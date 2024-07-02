// See https://aka.ms/new-console-template for more information

//Initializing variables
int examAssignments = 5;
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] sophiaScores = [ 90, 86, 87, 98, 100, 94, 90 ];
int[] andrewScores = [ 92, 89, 81, 96, 90, 89 ];
int[] emmaScores = [ 90, 85, 87, 98, 68,89, 89, 89 ];
int[] loganScores = [ 90, 95, 87, 88, 96, 96 ];

string currentStudent = "", currentLetterGrade = "";
int[] currentScores;
decimal currentExamScore = 0;

//Calculate Exam score, Grade and Credit Points for the students
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit");
foreach (string name in studentNames)
{
    currentStudent = name;

    //Assigning student scores
    if ( currentStudent == "Sophia")
        currentScores = sophiaScores;
    else if( currentStudent == "Andrew")
        currentScores = andrewScores;
    else if(currentStudent == "Emma")
        currentScores = emmaScores;
    else if(currentStudent == "Logan")
        currentScores = loganScores;
    else
        continue;

    //Initialize variables
    int gradedAssignments = 0, currentScore = 0;
    int creditAssignments = 0, currentCreditScore = 0;
    decimal currentGradeValue = 0;
    decimal currentExtraCreditValue = 0, currentCreditPts = 0;
    
    //Calculate exam score
    currentExamScore = (decimal)currentScores.Take(5).Sum() / examAssignments;

    //Calculate exam+credit score and credit score
    foreach (int score in currentScores)
    {
        gradedAssignments += 1;
        if(gradedAssignments <= examAssignments)
            currentScore += score;
        else
        {
            creditAssignments += 1;
            currentScore += score/ 10; //10% of each credit score to total
            currentCreditScore += score;
        }
    }
    currentGradeValue = (decimal)currentScore / examAssignments;

    currentExtraCreditValue = (decimal)currentCreditScore / creditAssignments;
    currentCreditPts = (decimal)(currentCreditScore / 10.0) / examAssignments;

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

    Console.WriteLine($"{currentStudent}\t\t{currentExamScore}\t\t{currentGradeValue}\t{currentLetterGrade}\t{currentExtraCreditValue} ({currentCreditPts} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();