using System;
using System.Collections;
using System.Collections.Generic;
public class Map
{
    private Terrain[][] grid;
    // INSTEAD OF A CLASS FOR DENOTING THE MAP SIZE, AN INT IS NOW USED
    private int mapSize;
    private List<Animal> animals = new List<Animal>();
    private List<Tourist> tourists = new List<Tourist>();
    private List<Ranger> rangers = new List<Ranger>();
    private List<Pond> ponds = new List<Pond>();
    private List<Road> roads = new List<Road>();
    private List<Plant> plants = new List<Plant>();


    public Map(int mapSize)
    {
        this.mapSize = mapSize;
        grid = new Terrain[mapSize][];
        for (int i = 0; i < mapSize; i++)
        {
            grid[i] = new Terrain[mapSize]; 
        }
    }

    public void GenerateMap()
    {
        //PLACEHOLDER
    }
    public int carnivoreCount()
    {
        return animals.OfType<Carnivore>().Count();
    }
    public int herbivoreCount()
    {
        return animals.OfType<Herbivore>().Count();
    }
    public int animalCount()
    {
        return animals.Count();
    }
    public List<Animal> getAllAnimals()
    {
        return animals;
    }
    public void addAnimal(Animal animal)
    {
        animals.Add(animal);
    }
    public void removeAnimal(Animal animal)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        animals.Remove(animal);
    }
    public void addTourist(Tourist tourist)
    {
        tourists.Add(tourist);
    }

    public void removeTourist(Tourist tourist)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        tourists.Remove(tourist);
    }
    public List<Tourist> getAllTourists()
    {
        return tourists;
    }
    public void addRanger(Ranger ranger)
    {
        rangers.Add(ranger);
    }
    public void removeRanger(Ranger ranger)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        rangers.Remove(ranger);
    }
    public List<Ranger> getAllRangers()
    {
        return rangers;
    }

    public void addPond(Pond pond)
    {
        ponds.Add(pond);
    }
    public void removePond(Pond pond)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        ponds.Remove(pond);
    }
    public List<Pond> getAllPonds()
    {
        return ponds;
    }

    public void addRoad(Road road)
    {
        roads.Add(road);
    }
    public void removeRoad(Road road)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        roads.Remove(road);
    }
    public List<Road> getAllRoads()
    {
        return roads;
    }
    public int getMapSize(){
        return mapSize;
    }

    //NO DISPLAY MAP FUNCTION ADDED BECUASE THIS IS PART OF THE VIEW #5
}