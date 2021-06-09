using System;

namespace Humans
{
    public class Human
{
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
    public int Health
    {
        get {return health;}
    }
    // add a public "getter" property to access health

    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    // Add a constructor to assign custom values to all fields
    // Build Attack method
    public Human(string n, int s, int i)
    {
        Name=n;
        Strength=s;
        Intelligence=i;
        Dexterity=3;
        health= 100;
    }
    public Human(string n, int s, int i, int d, int h)
    {
        Name=n;
        Strength=s;
        Intelligence=i;
        Dexterity=d;
        health=h;
    }

    public int Attack(Human target)
    {
        target.health-=5;
        Strength+=1;
        Console.WriteLine($"Health of {target.Name} is now {target.health}");
        Console.WriteLine($"Strength of {Name} is now {Strength}");
        return health;
    }
}

}