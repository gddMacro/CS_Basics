namespace Intro;

// Gathers all data to describe a unit for our game
public class Unit
{
    // state - implementation detail
    private string name;
    private int healthPoints;
    
    // introducing properties
    public int DamagePoints { get; set; }

    // behavior - public interface

    // Setter methods
    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) this.name = "Unnamed Unit";
        else
            this.name = name;
    }

    public void SetHealth(int health)
    {
        // Ternary operator
        this.healthPoints = (health < 0) ? 0 : health;
    }

    // Getter methods
    public string GetName()
    {
        return this.name;
    }

    public int GetHealth()
    {
        return this.healthPoints;
    }
}