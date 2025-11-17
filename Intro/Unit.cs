namespace Intro;

// Gathers all data to describe a unit for our game
public class Unit
{
    // state - implementation detail
    private string name;
    private int healthPoints;
    private int damagePoints;

    // behavior - public interface
    
    // Setter methods
    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) this.name = "Unnamed Unit";
        else
            this.name = name;
    }

    // Getter methods
    public string GetName()
    {
        return this.name;
    }

    public string GetDetails()
    {
        return $"{this.name} has {this.healthPoints} HP and {this.damagePoints} damage points.";
    }
}