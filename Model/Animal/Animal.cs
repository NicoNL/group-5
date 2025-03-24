using System;
using System.Numerics;

public abstract class Animal
{
    public int LifespanLimit { get; set; }
    public int Age { get; private set; }
    public int ConsumpLevel { get; set; }
    public bool CanReproduce { get; private set; }
    public int HungerLevel { get; private set; }
    public int ThirstLevel { get; private set; }
    private double price;
    private bool isAlive;
    private string group;
    private float health;

    public double Price
    {
        get { return price; }
        private set { price = value; }
    }

    public Animal(int lifespanLimit, int consumpLevel, double price)
    {
        LifespanLimit = lifespanLimit;
        ConsumpLevel = consumpLevel;
        Price = price;
        Age = 0;
        CanReproduce = false;
        HungerLevel = 0;
        ThirstLevel = 0;
        isAlive = true;
        health = 100f;
        group = "None";
    }

    // Movement
    public void Move(Vector2 destination)
    {
        Console.WriteLine($"Moving to {destination}");
    }

    // Food and water search
    private void FindFood()
    {
        Console.WriteLine("Searching for food...");
    }

    private void FindWater()
    {
        Console.WriteLine("Searching for water...");
    }

    // Eating and drinking
    private void Eat(Plant food)
    {
        Console.WriteLine($"Eating {food.getName()}.");
        HungerLevel = 0;
    }

    private void Drink(Pond waterSource)
    {
        Console.WriteLine("Drinking water.");
        ThirstLevel = 0;
    }

    // Checking needs
    private bool CheckHungerLevel()
    {
        return HungerLevel > 50;
    }

    private bool CheckThirstLevel()
    {
        return ThirstLevel > 50;
    }

    // Reproduction
    public Animal Reproduce(Animal partner)
    {
        if (CanReproduce && partner.CanReproduce)
        {
            Console.WriteLine("Reproduction successful!");
            return new Animal(LifespanLimit, ConsumpLevel, Price);
        }
        Console.WriteLine("Reproduction failed.");
        return null;
    }

    // Age and health management
    private void AgeUp()
    {
        Age++;
        if (Age >= LifespanLimit) Die();
        if (Age >= LifespanLimit / 2) CanReproduce = true;
    }

    private void Die()
    {
        isAlive = false;
        Console.WriteLine("The animal has died.");
    }

    public string GetStatus()
    {
        return $"Age: {Age}, Health: {health}, Hunger: {HungerLevel}, Thirst: {ThirstLevel}, Alive: {isAlive}";
    }

    public bool IsAlive()
    {
        return isAlive;
    }

    public void SetGroup(string group)
    {
        this.group = group;
    }

    public string GetGroup()
    {
        return group;
    }

    private void UpdateHealth(float value)
    {
        health = Math.Clamp(health + value, 0, 100);
        if (health <= 0) Die();
    }
}