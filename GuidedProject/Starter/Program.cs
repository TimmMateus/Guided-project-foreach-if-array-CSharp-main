using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

Console.WriteLine("Student\t\tGrade\n");

int[] studentScores = new int[10];

foreach (string name in studentNames)
{
    if(name == "Sophia") studentScores = sophiaScores;
    else if(name == "Andrew") studentScores = andrewScores;
    else if(name == "Emma") studentScores = emmaScores;
    else if(name == "Logan") studentScores = loganScores;
    else if (name == "Becky") studentScores = beckyScores;
    else if (name == "Chris") studentScores = chrisScores;
    else if (name == "Eric") studentScores = ericScores;
    else if (name == "Gregor") studentScores = gregorScores;
    else continue;

    int gradedAssignments = 0;
    int sumAssignmentScores = 0;
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
        else
            sumAssignmentScores += score / 10;
    }

    decimal studentScore = (decimal)(sumAssignmentScores) / examAssignments;

    String currentGrade="";
    if (studentScore >= 97)currentGrade = "A+";
    else if (studentScore >= 93)currentGrade = "A";
    else if (studentScore >= 90)currentGrade = "A-";
    else if (studentScore >= 87)currentGrade = "B+";
    else if (studentScore >= 83)currentGrade = "B";
    else if (studentScore >= 80)currentGrade = "B-";
    else if (studentScore >= 77)currentGrade = "C+";
    else if (studentScore >= 73)currentGrade = "C";
    else if (studentScore >= 70)currentGrade = "C-";
    else if (studentScore >= 67)currentGrade = "D+";
    else if (studentScore >= 63)currentGrade = "D";
    else if (studentScore >= 60)currentGrade = "D-";
    else currentGrade = "F";

    Console.WriteLine(name + "\t\t" + studentScore + "\t" + currentGrade);

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
