// Create a RTS simulator using arrays, functions, loops, control-flow (NO CLASSES YET).
// Create at least 2 factions with units that are supposed to battle each other and to gather resources
// from each unit defeated. Also implement some simple selection logic to select # of units of your battalion.
// This unit is then entering the battle field. within the battle realm you have the opportunity to decide what
// units are screening the battle field for ressources and which are supposed to fight.


// Unit description 

using Intro;

string[] unitNames = new[] { "Ice", "Fire", "Earth", "Water", "Air" };
int[] unitHealthPoints = new[] { 100, 90, 200, 1200, 900 };
int[] unitDamagePoints = new[] { 12, 22, 30, 100, 127 };

Unit[] units = new Unit[5];
units[0] = new Unit();
units[0].SetName("lkasjdljashdl");

// Resources.
string[] resourceNames = new[] { "Iron", "Gold", "Wood" };
int[] resourceAmounts = new[] { 0, 0, 0 };

// Basic unit selection
// Console.WriteLine("Select the units you want to command. Selectable units are:");
// for (var i = 0; i < unitNames.Length; i++)
//     Console.WriteLine($"{i + 1}) {unitNames[i]}"); // Printing out all available units
//
// Console.WriteLine($"The system is expecting your selection. Select and range from 1 to {unitNames.Length}.");
// var min = int.Parse(Console.ReadLine()); // determine where to start selection
// Console.WriteLine("Enter your last unit you want to select. Type -1, if you just want to select a single unit");
// var max = int.Parse(Console.ReadLine()); // determine where to stop unit selection
//
// // Very basic unit selection that does NOT consider edge cases like invalid indices.
// Console.WriteLine("You have selected the following unit/s:");
// if (max < 0 || max <= min) // select 1 unit only, if chosen by the player
//     Console.WriteLine(
//         $"Unit {min}: {unitNames[min - 1]} has {unitHealthPoints[min - 1]}hp and makes {unitDamagePoints[min - 1]} damage.");
// else
// {
//     // 3        -        6
//     // Bums, Bams, Bims , Böms, Bummel, Wummel, Fummel
//     var indexRange = (max - min); // calculate complete selected range to iterate over
//     var calculatedEnd = min + indexRange;
//     if (calculatedEnd <= unitNames.Length)
//     {
//         for (var i = min - 1; i < calculatedEnd; i++)
//             Console.WriteLine(
//                 $"Unit {i + 1}: {unitNames[i]} has {unitHealthPoints[i]}hp and makes {unitDamagePoints[i]} damage.");
//     }
// }