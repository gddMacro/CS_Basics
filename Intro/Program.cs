// Create a RTS simulator using arrays, functions, loops, control-flow (NO CLASSES YET).
// Create at least 2 factions with units that are supposed to battle each other and to gather resources
// from each unit defeated. Also implement some simple selection logic to select # of units of your battalion.
// This unit is then entering the battle field. within the battle realm you have the opportunity to decide what
// units are screening the battle field for ressources and which are supposed to fight.


// Unit description 

string[] unitNames = new[] { "Ice", "Fire", "Earth" };
int[] unitHealthPoints = new[] { 100, 90, 200 };
int[] unitDamagePoints = new[] { 12, 22, 30 };

// Resources
string[] resourceNames = new[] { "Iron", "Gold", "Wood" };
int[] resourceAmounts = new[] { 0, 0, 0 };

// Basic unit selection
Console.WriteLine("Select the units you want to command. Selectable units are:");
for (var i = 0; i < unitNames.Length; i++)
    Console.WriteLine($"{i + 1}) {unitNames[i]}"); // Printing out all available units

Console.WriteLine($"The system is expecting your selection. Select and range from 1 to {unitNames.Length}.");
var min = int.Parse(Console.ReadLine()); // determine where to start selection
Console.WriteLine("Enter your last unit you want to select. Type -1, if you just want to select a single unit");
var max = int.Parse(Console.ReadLine()); // determine where to stop unit selection

