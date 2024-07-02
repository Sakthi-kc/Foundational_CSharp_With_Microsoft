// See https://aka.ms/new-console-template for more information
using System;

//Calculate GPA and Grade for 4 students
int currentAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Nicolas", "Zahirah", "Jeong" };

int[] sofiaScores = [ 93, 87, 98, 95, 100 ];
int[] nicolasScores = [ 80, 83, 82, 88, 85 ];
int[] zahirahScores = [ 84, 96, 73, 85, 79 ];
int[] jeongScores = new int[] { 90, 92, 98, 100, 97 };

int sofiaSum = sofiaScores[0] + sofiaScores[1] + sofiaScores[2] + sofiaScores[3] + sofiaScores[4];
int nicolasSum = nicolasScores.Sum();
int zahirahSum = zahirahScores.Sum();
int jeongSum = jeongScores.Sum();

decimal sofiaScore = (decimal)sofiaSum / currentAssignments;
decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
decimal jeongScore = (decimal)jeongSum / currentAssignments;

Console.WriteLine("student\t\tGrade");
Console.WriteLine("Sofia\t\t{0}\tA", sofiaScore);
Console.WriteLine("Nicolas\t\t{0}\tB", nicolasScore);
Console.WriteLine("Zahirah\t\t{0}\tB", zahirahScore);
Console.WriteLine("Jeong\t\t{0}\tA", jeongScore);