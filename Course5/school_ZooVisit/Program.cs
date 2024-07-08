using System;

//Initializing animals
string[] zooAnimals =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises"
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine($"\n" + schoolName);
    PrintGroup(group);
}

void RandomizeAnimals()
{
    Random random = new Random();

    for (int iteration = 0; iteration < zooAnimals.Length; iteration++)
    {
        int index = random.Next(iteration, zooAnimals.Length);

        string temp = zooAnimals[index];
        zooAnimals[index] = zooAnimals[iteration];
        zooAnimals[iteration] = temp;
    }
}

string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, zooAnimals.Length / groups];
    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = zooAnimals[start++];
        }
    }

    return result;
}

void PrintGroup(string[,] groups)
{
    for (int i = 0; i < groups.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < groups.GetLength(1); j++)
        {
            Console.Write($"{groups[i, j]}  ");
        }
        Console.WriteLine();
    }
}