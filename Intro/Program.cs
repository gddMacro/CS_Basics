// Create a RTS simulator using arrays, functions, loops, control-flow (NO CLASSES YET).
// Create at least 2 factions with units that are supposed to battle each other and to gather resources
// from each unit defeated. Also implement some simple selection logic to select # of units of your battalion.
// This unit is then entering the battle field. within the battle realm you have the opportunity to decide what
// units are screening the battle field for ressources and which are supposed to fight.


// Unit description 

using Intro;

// Creating a bucket full of units where each unit has a name, health points and damage points.   
var units = new[]
{
    new Unit { Name = "Ice", HealthPoints = 120, DamagePoints = 12 },
    new Unit { Name = "Fire", HealthPoints = 90, DamagePoints = 22 },
    new Unit { Name = "Earth", HealthPoints = 200, DamagePoints = 30 },
    new Unit { Name = "Water", HealthPoints = 1200, DamagePoints = 100 },
    new Unit { Name = "Air", HealthPoints = 900, DamagePoints = 127 }
};

// Resources.
string[] resourceNames = new[] { "Iron", "Gold", "Wood" };
int[] resourceAmounts = new[] { 0, 0, 0 };

// Basic unit selection
Console.WriteLine("Select the units you want to command. Selectable units are:");
for (var i = 0; i < units.Length; i++)
    Console.WriteLine($"{i + 1}) {units[i].Name}"); // Printing out all available units

Console.WriteLine($"The system is expecting your selection. Select and range from 1 to {units.Length}.");
var min = int.Parse(Console.ReadLine()); // determine where to start selection
Console.WriteLine("Enter your last unit you want to select. Type -1, if you just want to select a single unit");
var max = int.Parse(Console.ReadLine()); // determine where to stop unit selection

// Very basic unit selection that does NOT consider edge cases like invalid indices.
Console.WriteLine("You have selected the following unit/s:");
if (max < 0 || max <= min) // select 1 unit only, if chosen by the player
    Console.WriteLine(
        $"Unit {min}: {units[min - 1].Name} has {units[min - 1].HealthPoints}hp and makes {units[min - 1].DamagePoints} damage.");
else
{
    // 3        -        6
    // Bums, Bams, Bims , Böms, Bummel, Wummel, Fummel
    var indexRange = (max - min); // calculate complete selected range to iterate over
    var calculatedEnd = min + indexRange;
    if (calculatedEnd <= units.Length)
    {
        // instead of connecting different arrays together by identifying the correct index,
        // we can just iterate over the array and handle each unit by itself with
        // its respective details / data set.
        for (var i = min - 1; i < calculatedEnd; i++)
        {
            var currentUnit = units[i];
            Console.WriteLine(
                $"Unit {i + 1}: {currentUnit.Name} has {currentUnit.HealthPoints}hp and makes {currentUnit.DamagePoints} damage.");
        }
    }
}