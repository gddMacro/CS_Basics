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

