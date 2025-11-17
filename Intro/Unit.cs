namespace Intro;

// Gathers all data to describe a unit for our game
public class Unit
{
    public string Name { get; set; }
    public int DamagePoints { get; set; }

    public int Armor { get; init; }

    // Property to read healthpoints only - no write
    public int GetHealth => this.healthPoints;

    // Keep health private / inaccessible from outside so it cannot be modified directly
    private int healthPoints;


    // Constructor to initialize healthpoints
    public Unit(int healthPoints)
    {
        this.healthPoints = healthPoints;
    }

    public void TakeDamage(int rawDamage)
    {
        var incomingDamage = rawDamage - this.Armor;
        if (incomingDamage < 0) return;
        this.healthPoints = 120;
    }
}