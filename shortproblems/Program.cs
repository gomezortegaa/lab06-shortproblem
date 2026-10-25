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

Console.WriteLine("=== CSCI 1250 Lab 06===");

Console.WriteLine("1. The Grade Checker");


Console.WriteLine("2. The Dice Table");


Console.WriteLine("3. The Score Report");
if (choice == 3 || choice == 4)
{
    
}
Console.WriteLine("4. All Three");
Console.WriteLine("5. Quit");

Console.WriteLine("Choose 1 Through 5: ");
choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1 || choice == 4)
{
    Console.WriteLine("Enter a Score");
    int scorechoice = Convert.ToInt32(Console.ReadLine());
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