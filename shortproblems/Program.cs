/*
* Name: Andy Gomez
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

using System.Formats.Asn1;

Random rng = new Random(4000);
int choice = 0;




//Do While Loop: Do While loops whatever is inside the brackets atleast once, While checking if conditions are true
//In this case, the Do is the Menu and the excerises, until choice is 5, which ends the program
do
{

Console.WriteLine("=== CSCI 1250 Lab 06 ===");
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Game");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All three");
Console.WriteLine("5. Quit");

Console.WriteLine("Choose 1 Through 5: ");
choice = Convert.ToInt32(Console.ReadLine());

while (choice < 1 || choice > 5)
{
    Console.WriteLine("Choose a number between 1 to 5");
    Console.WriteLine("Choose 1 Through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());
}

if (choice == 1 || choice == 4)
{
    Console.WriteLine("=== Exercise 1: The Grade Checker ===");
    Console.WriteLine("Enter a Score");
    int scorechoice = Convert.ToInt32(Console.ReadLine());

//While Loop: The While Loop checks if inputted values meets specific conditions
//By prompting the user to input a score, the While loops checks its validity.  if and else if determine the grade the score earns.

    while(scorechoice < 0 || scorechoice > 100)
    {
        Console.WriteLine("Score must be between 0 - 100");
        Console.WriteLine("Enter Score"); 
        scorechoice = Convert.ToInt32(Console.ReadLine()); 
    }

    
        if(scorechoice >= 90)
        {
            Console.WriteLine(scorechoice + " earns a A");
        } 
        else if (scorechoice >= 80)
        {
            Console.WriteLine(scorechoice + " earns a B");
        }
        else if (scorechoice >= 70)
        {
            Console.WriteLine(scorechoice + " earns a C");
        }
        else if (scorechoice >= 60)
        {
            Console.WriteLine(scorechoice + " earns a D");
        }
        else
        {
            Console.WriteLine(scorechoice + " earns a F");
        }

        
    } 


// Part 2
if (choice == 2 || choice == 4)
{

Console.WriteLine("=== Excercise 2: The Dice Table ===");

    int wins = 0;
    int rolls = 0;
    string? answer;

    do
    {
        int dice1 = rng.Next(1,7);
        int dice2 = rng.Next(1,7);
  

        rolls++;
        int total = dice1 + dice2;

        Console.WriteLine("Rolls " + rolls + ": " + dice1 + " and " + dice2 + ", total " + total + ". ");


        if (dice1 == 1 && dice2 == 1) 
        {
            Console.Write("Snakes Eyes");
        }
        else if (dice1 == dice2 || dice2 != 1 && dice1 != 1)
        {
            Console.Write("Doubles!");
        }
        else if (total == 7 || total == 11)
        {
            Console.Write("A winner");
            wins++;
        }

        Console.WriteLine();

        Console.WriteLine("Roll again? (y/n): ");
        answer = Console.ReadLine();
            
    }while(answer == "y");

    Console.WriteLine("You rolled " + rolls + " times and " + "won " + wins);

}


//Part 3
if (choice == 3 || choice == 4)
{
Console.WriteLine("=== Excerise 2: The Score Report ===");

int[] scores = new int[5];
int total = 0;
int longest = 0;
int passing = 0;
double average = 0;

//For Loop: For Loop runs when conditions are true
//In this case: the For Loop checks if "i" is less than "scores.Length" (being 5)
//if true, it runs the block of code, asking for scores and reading user inputs
//instead of indivdually asking 5 times

for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine("Score " + (i + 1) + ": ");
    scores[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Scores Entered: " + scores.Length);

//For Each Loop: The ForEach loop runs specific instructions to each value in a array
//In this case: the foreach picks one value in an array 
//adds it to a total, checks if its the highest score, and checks ifs a passing grade
//instead of doing it 1 by 1.

foreach(int score in scores)
    {
        total = total + score;
        longest = Math.Max(longest, score);
        if(score >= 60)
        {
            passing++;
        }

    }
average = (double)total / scores.Length;

Console.WriteLine("Total: " + total);
Console.WriteLine("Average: " + average);
Console.WriteLine("Highest: " + longest);
Console.WriteLine("Passing: " + passing + " of " + scores.Length);
}




}while(choice != 5);

Console.WriteLine("Goodbye!");