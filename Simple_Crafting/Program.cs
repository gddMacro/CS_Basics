namespace Simple_Crafting;

// This is the MAIN program - it's like the front door to our game!
// 
// WHY we use it: Every program needs a starting point, and this is it!
// Think of it like pressing the "Start" button on a video game controller.
//
// WHEN it runs: This runs automatically when you start the program.
// It's the FIRST thing that happens!
//
// HOW it works: It sets up our resource storage and checks if we have materials.
// Then it shows us the answer on the screen!
class Program
{
    // This is the Main method - the actual "Start Button" of our program!
    // Everything inside these curly braces { } happens in order, line by line.
    static void Main(string[] args)
    {
         // STEP 1: Set up our storage warehouse with 1000 empty slots
         // This is like opening a brand new storage building before we can put anything in it!
         ResourceManagementSystem.Init(1000);

         // STEP 2: Check if we have at least 100 Iron in our storage
         // We save the answer (true or false) in a variable called "isIronInStorage"
         // It's like asking the warehouse worker: "Do we have 100 Iron?" and writing down their yes/no answer!
         var isIronInStorage = ResourceManagementSystem.IsResourceAvailable("Iron", 100);

         // STEP 3: Show the answer on the screen!
         // This prints either "True" (we have enough) or "False" (we don't have enough)
         // Console.WriteLine is like a megaphone that shouts the answer so we can see it!
         Console.WriteLine(isIronInStorage);
    }
}