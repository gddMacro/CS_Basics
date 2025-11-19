namespace Simple_Crafting;

// This is like a storage warehouse for a game!
// It keeps track of all the resources (like wood, iron, gold) that the player has collected.
// We use this to check if the player has enough materials before they can craft something.
// For example: "Do I have 100 iron to make a sword?"
public static class ResourceManagementSystem
{
    // This is our storage box that holds all the resources.
    // It's an array (like a list of slots) where each slot can hold one type of resource.
    // We keep it "private" so nobody can mess with it directly from outside - they have to use our special methods instead!
    private static Resource[] resources;

    // This method sets up our storage warehouse when the game starts.
    // "Init" is short for "Initialize" which means "get ready to use"!
    // We tell it how many different types of resources we can store (maxResources).
    // For example: Init(1000) creates a warehouse with 1000 empty slots.
    public static void Init(int maxResources)
    {
        resources = new Resource[maxResources];
    }

    // This method checks if we have enough of a specific resource.
    // It's like asking: "Do I have at least 100 iron in my storage?"
    // It returns "true" if we have enough, or "false" if we don't.
    public static bool IsResourceAvailable(string resourceName, int amountRequested)
    {
        // This loop looks through every single resource in our storage, one by one.
        // It's like checking each box in the warehouse to find the one we need.
        foreach (var resource in resources)
        {
            // This line checks 3 things and skips this resource if ANY of them are true:
            // 1. Is this slot empty (null)? Skip it!
            // 2. Is this the wrong resource (not the name we're looking for)? Skip it!
            // 3. Do we have less than what we need? Skip it!
            // "continue" means "stop here and check the next one"
            if (resource == null || !resource.Name.Equals(resourceName) || resource.Amount < amountRequested) continue;

            // If we get here, it means we found the right resource AND we have enough of it!
            // Return "true" to say "Yes, we have what you need!"
            return true;
        }
        // If we checked all the resources and never returned true, it means we don't have enough.
        // So we return "false" to say "Sorry, we don't have enough of that resource."
        return false;
    }

    // This method ADDS resources to our storage warehouse!
    // 
    // WHAT it does: It either adds MORE to an existing resource, or creates a NEW resource if we don't have it yet.
    // For example: If we already have 10 Iron and we Add("Iron", 5), we'll end up with 15 Iron total!
    //
    // WHY we use it: When players collect resources in the game (like mining iron or chopping trees),
    // we need to update our storage to remember what they found!
    //
    // WHEN we use it: Every time the player picks up or earns a resource!
    // - When mining rocks for iron
    // - When chopping trees for wood
    // - When winning gold from a quest
    // - When buying materials from a shop
    public static void Add(string name, int amount)
    {
        // This loop looks through EVERY slot in our storage warehouse, one by one.
        // We use "i" as a counter to keep track of which slot number we're checking (0, 1, 2, 3...)
        for (var i = 0; i < resources.Length; i++)
        {
            // This checks TWO things: Is this slot filled (not null)? AND Is it the resource we're looking for?
            // If BOTH are true, it means we ALREADY HAVE this resource stored, so we should add to it!
            if (resources[i] != null && resources[i].Name.Equals(name))
            {
                // We found the resource! Now ADD the new amount to what we already have.
                // The "+=" means "add to the existing amount". If we had 10 and add 5, we now have 15!
                resources[i].Amount += amount;
                // Stop here and exit the method! We're done - we added to the existing resource!
                return;
            }

            // This checks if the current slot is EMPTY (null means nothing is stored there).
            // If it's empty AND we didn't find the resource above, this must be a NEW resource type!
            if (resources[i] == null)
            {
                // Create a BRAND NEW resource and put it in this empty slot!
                // It's like putting a new labeled box in the warehouse with the name and starting amount.
                resources[i] = new Resource { Name = name, Amount = amount };
                // Stop here and exit the method! We're done - we created a new resource!
                return;
            }
        }
    }
    
}