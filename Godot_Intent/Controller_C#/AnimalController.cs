using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

public class AnimalController
{
    private List<Animal> animals;
    private List<Herbivore> herbivores;
    private List<Carnivore> carnivores;
    private Dictionary<string, List<Animal>> animalGroups;
    private float hungerThreshold;
    private float thirstThreshold;
    private float reproductionCooldown;
    private float movementSpeedMultiplier;
    private List<Animal> deadAnimals;

    public AnimalController(float hungerThreshold = 50f, float thirstThreshold = 50f, 
                            float reproductionCooldown = 10f, float movementSpeedMultiplier = 1f)
    {
        animals = new List<Animal>();
        herbivores = new List<Herbivore>();
        carnivores = new List<Carnivore>();
        animalGroups = new Dictionary<string, List<Animal>>();
        deadAnimals = new List<Animal>();
        this.hungerThreshold = hungerThreshold;
        this.thirstThreshold = thirstThreshold;
        this.reproductionCooldown = reproductionCooldown;
        this.movementSpeedMultiplier = movementSpeedMultiplier;
    }

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
        if (animal is Herbivore) herbivores.Add((Herbivore)animal);
        if (animal is Carnivore) carnivores.Add((Carnivore)animal);

        if (!animalGroups.ContainsKey(animal.GetGroup()))
            animalGroups[animal.GetGroup()] = new List<Animal>();

        animalGroups[animal.GetGroup()].Add(animal);
    }

    public void RemoveAnimal(Animal animal)
    {
        animals.Remove(animal);
        if (animal is Herbivore) herbivores.Remove((Herbivore)animal);
        if (animal is Carnivore) carnivores.Remove((Carnivore)animal);

        if (animalGroups.ContainsKey(animal.GetGroup()))
            animalGroups[animal.GetGroup()].Remove(animal);
    }

    public Animal GetAnimalById(int id)
    {
        return animals.ElementAtOrDefault(id);
    }

    public void UpdateAnimals()
    {
        foreach (var animal in animals)
        {
            if (!animal.IsAlive())
            {
                HandleAnimalDeath(animal);
                continue;
            }

            if (CheckHungerLevel(animal)) FindNearestFoodSource(animal);
            if (CheckThirstLevel(animal)) FindNearestWaterSource(animal);
        }

        RemoveDeadAnimals();
        HandleReproduction(animals);
        UpdateAnimalMovement();
    }

    public void MoveAnimal(Animal animal, Vector2 destination)
    {
        animal.Move(destination);
    }

    public Pond FindNearestWaterSource(Animal animal)
    {
      
        // Placeholder logic, replace with actual logic
        return new Pond();
    }

    public Plant FindNearestFoodSource(Animal animal)
    {
        // Placeholder logic( NOT ADDED YET)
        return new Plant("Grass");
    }

    public void UpdateAnimalMovement()
    {
        foreach (var animal in animals)
        {
            Vector2 randomDestination = new Vector2(new Random().Next(0, 100), new Random().Next(0, 100));
            MoveAnimal(animal, randomDestination);
        }
    }

    public bool CheckHungerLevel(Animal animal)
    {
        return animal.HungerLevel > hungerThreshold;
    }

    public bool CheckThirstLevel(Animal animal)
    {
        return animal.ThirstLevel > thirstThreshold;
    }

    public void FeedAnimal(Animal animal, Plant food)
    {
        animal.Eat(food);
    }

    public void GiveWaterToAnimal(Animal animal, Pond pond)
    {
        animal.Drink(pond);
    }

    public bool CanReproduce(Animal animal)
    {
        return animal.CanReproduce;
    }

    public void HandleReproduction(List<Animal> animals)
    {
        for (int i = 0; i < animals.Count; i++)
        {
            for (int j = i + 1; j < animals.Count; j++)
            {
                if (CanReproduce(animals[i]) && CanReproduce(animals[j]))
                {
                    Animal offspring = animals[i].Reproduce(animals[j]);
                    if (offspring != null) AddAnimal(offspring);
                }
            }
        }
    }

    public void HandleAnimalDeath(Animal animal)
    {
        if (!animal.IsAlive() && !deadAnimals.Contains(animal))
            deadAnimals.Add(animal);
    }

    public void RemoveDeadAnimals()
    {
        foreach (var animal in deadAnimals)
            RemoveAnimal(animal);

        deadAnimals.Clear();
    }
}
