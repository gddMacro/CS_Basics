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
    
}