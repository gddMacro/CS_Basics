// string - text
// bool - true or false
// int - whole number 
// float - floating point number
// double - just bigger floating point number
// char - single character
// long - really big whole number
// short - just some whole number, smaller than int
// byte - smallest whole number


// DataType variableName = value;

// variable declaration and initialization with explicit type

using System.Runtime.CompilerServices;

int geraltsHealth = 105;
string spell = "Fireball";
char guildSymbol = 'G';

// implicit type declaration
var geraltsStrength = 10;

// output to console
Console.WriteLine("This is the story of Geralt. He belongs to the guild of " + guildSymbol + ".");

// enemy - monster
int monsterHealth = 80;
int monsterStrength = 2;
int monsterAgility = 3;

// Simple battle simulation
// Geralt tries to slay the monster
Console.WriteLine("Monster attacks Geralt");
geraltsHealth -= monsterStrength;

Console.WriteLine("Geralt attacks monster");
monsterHealth -= geraltsStrength;

Console.WriteLine("Geralt's health: " + geraltsHealth);
Console.WriteLine("Monster's health: " + monsterHealth);

// Basic control flow
if (monsterHealth <= 10)
{
    if (int.Parse(Console.ReadLine()) != monsterAgility)
        Console.WriteLine("Missed monster!");
    else
        Console.WriteLine("Monster is close to death....");
}
else if (monsterHealth <= 20) // is only being evaluated, if the previous condition is not met
{
    Console.WriteLine("Monster is not quite dead yet....");
}
else // fallback, if non has been true
{
    Console.WriteLine("....");
}

// Loops 
// Is being used, if number of iterations is uncertain
while (geraltsHealth > 0) // is being executed until geralt is dead -> hp < 0
{
    // Battle simulation
    Console.WriteLine("Geralt attacks Monster");
    monsterHealth -= geraltsStrength;
    Console.WriteLine($"Monster is down to {monsterHealth} hp.");

    if (monsterHealth <= 0) // if monster is already slain, break out of loop
        break; // terminates the loop

    Console.WriteLine("Geralt is being attacked...");
    geraltsHealth -= monsterStrength;
    Console.WriteLine($"Geralt is down to {geraltsHealth} hp.");
}

string sword = "Super Sword";
string axe = "Ice Axe";
string bow = "AK47";

// Print all weapons
Console.WriteLine(sword);
Console.WriteLine(axe);
Console.WriteLine(bow);

// Arrays
string[] weapons = new string[2];
weapons[1] = "AK-47"; // adding stuff to the slot
Console.WriteLine(weapons[1]); // looking into the slot to work with the stuff that's in it

weapons[0] = "Golden-Cross-Bow";


// for-loop
// used when number of iterations is clear
for (int i = 0; i < weapons.Length; i++)
{
    Console.WriteLine(weapons[i]);
}

// Exercise Player count -> player names -> print all player names
Console.Write("Please enter the # of players joined: ");
int playerCount = GetNumericValueFromString(Console.ReadLine()); // determine array size
string[] playerNames = new string[playerCount]; // create array with set size
for (int i = 0; i < playerCount; i++)
{
    Console.WriteLine("Please enter the name of the player: ");
    playerNames[i] = Console.ReadLine(); // store current player name
}


// Function call with playerNames array as argument
PrintTexts(playerNames);


// Exercise array application -> Create, Fill, Read(Print)
Console.WriteLine("Enter # of texts");
var textFragmentCount = GetNumericValueFromString(Console.ReadLine());
var texts = GetStringAarray(textFragmentCount);
PrintTexts(texts);


// functions 
// returnType functionName(datatype parameterName) {..here goes the logic..}
// Definition
void PrintTexts(string[] texts)
{
    foreach (var playerName in texts)
    {
        Console.WriteLine(playerName); // print current player name observed
    }
}


// Function with return type -> getting sth to work with -> minion takes back stuff that can be reused
int GetNumericValueFromString(string text)
{
    return int.Parse(text);
}

// Exercise
// create a method for generating a string array of a certain size 
// Create a method to print all entries of this or any similar array

string[] GetStringAarray(int size)
{
    string[] texts = new string[size]; // Create array of type string with # of elements 
    FillStringArray(texts); // Call method to assign actual value to each slot
    return texts; // deliver back filled array of given size
}

void FillStringArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++) // Loop through complete array
    {
        Console.WriteLine($"Enter value for {i} entry"); // Print what slot we are on
        stringArray[i] = Console.ReadLine(); // Store actual value in current slot
    }
}

