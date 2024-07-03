// See https://aka.ms/new-console-template for more information

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string readResult;
string menuSelection = "";

int petCount = 0;
string anotherPet = "n";
bool validEntry = false;
int petAge = 0;

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

//Assign pet values to matrix
for (int iteration = 0; iteration < maxPets; iteration++)
{
    switch (iteration)
    {
        case 0:
        {
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        }
        case 1:
        {
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        }
        case 2:
        {
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        }
        case 3:
        {
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        }
        default:
        {
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        }
    }

        ourAnimals[iteration, 0] = "ID #: " + animalID;
        ourAnimals[iteration, 1] = "Species: " + animalSpecies;
        ourAnimals[iteration, 2] = "Age: " + animalAge;
        ourAnimals[iteration, 3] = "Nickname: " + animalNickname;
        ourAnimals[iteration, 4] = "Physical description: " + animalPhysicalDescription;
        ourAnimals[iteration, 5] = "Personality: " + animalPersonalityDescription;
}

//Show the options to customers
Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");

//Read user input and perform necessary action
Console.WriteLine("\nEnter your selection number (or type Exit to exit the program)");

readResult = Console.ReadLine();
if (readResult != null)
{
    menuSelection = readResult.ToLower();
}
Console.WriteLine($"You selected menu option {menuSelection}.");

switch (menuSelection)
{
    case "1":
        // List all of our current pet information
        for (int row = 0; row < maxPets; row++)
        {
            if (ourAnimals[row, 0] != "ID #: ")
            {
                Console.WriteLine();
                for (int col = 0; col < 6; col++)
                {
                    Console.WriteLine(ourAnimals[row,col].ToString());
                }
            }
        }
        Console.WriteLine("Press the Enter key to continue.");
        break;

    case "2":
        // Add a new animal friend to the ourAnimals array
        //
        // The ourAnimals array contains
        //    1. the species (cat or dog). a required field
        //    2. the ID number - for example C17
        //    3. the pet's age. can be blank at initial entry.
        //    4. the pet's nickname. can be blank.
        //    5. a description of the pet's physical appearance. can be blank.
        //    6. a description of the pet's personality. can be blank.
        anotherPet = "y";

        for (int row = 0; row < maxPets; row++)
        {
            if (ourAnimals[row, 0] != "ID #: ")
                petCount++ ;
        }

        while (anotherPet == "y" && petCount < maxPets)
        {
            // get species (cat or dog) - string animalSpecies is a required field 
            do
            {
                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalSpecies = readResult.ToUpper();
                    if (animalSpecies != "dog" && animalSpecies != "cat")
                        validEntry = false;
                    else
                        validEntry = true;
                }
            } while (validEntry == false);

            // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
            animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

            // get the pet's age. can be ? at initial entry.
            do
            {
                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalAge = readResult;
                    if (animalAge != "?")
                        validEntry = int.TryParse(animalAge, out petAge);
                    else
                        validEntry = true;
                }
            } while (validEntry == false);

            // get a description of the pet's physical appearance - animalPhysicalDescription can be blank.
            do
            {
                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalPhysicalDescription = readResult;
                    if (animalPhysicalDescription == "")
                        animalPhysicalDescription = "tbd";
                }
            } while (validEntry == false);


            // get a description of the pet's personality - animalPersonalityDescription can be blank.
            do
            {
                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalPersonalityDescription = readResult;
                    if (animalPersonalityDescription == "")
                        animalPersonalityDescription = "tbd";
                }
            } while (validEntry == false);

            // get the pet's nickname. animalNickname can be blank.
            do
            {
                Console.WriteLine("Enter a nickname for the pet");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalNickname = readResult;
                    if (animalNickname == "")
                        animalNickname = "tbd";
                }
            } while (validEntry == false);

            // store the pet information in the ourAnimals array (zero based)
            ourAnimals[petCount, 0] = "ID #: " + animalID;
            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
            ourAnimals[petCount, 2] = "Age: " + animalAge;
            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

            // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
            petCount = petCount + 1;

            // check maxPet limit
            if (petCount < maxPets)
            {
                // another pet?
                Console.WriteLine("Do you want to enter info for another pet (y/n)");
                do
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                        anotherPet = readResult.ToLower();

                } while (anotherPet != "y" && anotherPet != "n");
            }
            //NOTE: The value of anotherPet (either "y" or "n") is evaluated in the while statement expression - at the top of the while loop
        }

        if (petCount >= maxPets)
            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
        
        Console.WriteLine("Press the Enter key to continue.");
        break;

    case "3":
        // Ensure animal ages and physical descriptions are complete
        //
        //    ourAnimals[i, 2] = "Age: " + animalAge;
        //    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;

        for(int row = 0; row < maxPets; row++)
        {
            if (ourAnimals[row, 2] == "Age: ?" && ourAnimals[row, 0] != "ID #: ")
            {
                do
                {
                    Console.WriteLine($"Enter an age for {ourAnimals[row, 0]}");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        validEntry = int.TryParse(animalAge, out petAge);
                    }
                } while (validEntry == false);
                ourAnimals[row, 2] = "Age: " + animalAge.ToString();
            }

            if (ourAnimals[row, 4] == "Physical description: " && ourAnimals[row, 0] != "ID #: ")
            {
                do
                {
                    Console.WriteLine($"Enter a physical description for {ourAnimals[row, 0]} (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                            validEntry = false;
                        else
                            validEntry = true;
                    }
                } while (validEntry == false);

                ourAnimals[row, 4] = "Physical description: " + animalPhysicalDescription;
            }
        }

        Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends.");
        Console.WriteLine("Press the Enter key to continue.");
        break;

    case "4":
        // Ensure animal nickname and personality descriptions are complete
        //
        //    ourAnimals[i, 3] = "Nickname: " + animalNickname;
        //    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
        for (int row = 0; row < maxPets; row++)
        {
            if (ourAnimals[row, 3] == "Nickname: " && ourAnimals[row, 0] != "ID #: ")
            {
                do
                {
                    Console.WriteLine($"Enter a nickname for {ourAnimals[row, 0]}");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult;
                        validEntry = int.TryParse(animalNickname, out petAge);
                    }
                } while (validEntry == false);
                ourAnimals[row, 3] = "Nickname: " + animalNickname.ToString();
            }

            if (ourAnimals[row, 5] == "Personality: " && ourAnimals[row, 0] != "ID #: ")
            {
                do
                {
                    Console.WriteLine($"Enter a Personality description for {ourAnimals[row, 0]} (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                            validEntry = false;
                        else
                            validEntry = true;
                    }
                } while (validEntry == false);

                ourAnimals[row, 4] = "Personality description: " + animalPersonalityDescription;
            }
        }

        Console.WriteLine("\n\rNickname and personal description fields are complete for all of our friends.");
        Console.WriteLine("Press the Enter key to continue.");
        break;

    case "5":
    case "6":
    case "7":
    case "8":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        break;

    default:
        break;
}

// pause code execution
Console.ReadLine();
