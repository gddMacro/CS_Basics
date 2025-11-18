namespace Simple_Crafting;

// This is like a label or index card for ONE type of resource in our game!
// 
// WHY we use it: In games, players collect materials like wood, iron, or gold.
// We need a way to remember the NAME of each material, HOW MUCH we have, and HOW MUCH it COSTS.
// This class is like a recipe card that stores all that information in one place!
//
// HOW we use it: We create a Resource object for each material type.
// For example: one Resource for "Iron", another for "Wood", another for "Gold".
//
// WHEN we use it: Whenever we need to store information about a crafting material!
// - When adding items to our storage warehouse (see ResourceManagementSystem)
// - When checking if we have enough materials to craft something
// - When buying or selling resources in a shop
public class Resource
{
    // This stores the NAME of the resource (like "Iron", "Wood", or "Gold")
    // It's a string because names are made of letters!
    public string Name { get; set; }

    // This stores HOW MANY of this resource we have (like 50 iron or 200 wood)
    // It's an int (whole number) because you can't have half a piece of iron!
    public int Amount { get; set; }

    // This stores HOW MUCH one piece of this resource costs (like 2.5 gold coins)
    // It's a float (decimal number) because prices can have cents or decimal values!
    public float Price { get; set; }
}