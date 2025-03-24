using System;
using System.Collections;

public class Map
{
    private Terrain[][] grid;
    // INSTEAD OF A CLASS FOR DENOTING THE MAP SIZE, AN INT IS NOW USED
    private int mapSize;
    private ArrayList<Animal> animals = ArrayList<Animal>;
    private ArrayList<Tourist> tourists = ArrayList<Tourist>;
    private ArrayList<Ranger> rangers = ArrayList<Ranger>;
    private ArrayList<Pond> ponds = ArrayList<Pond>;
    private ArrayList<Road> roads = ArrayList<Road>;
    private ArrayList<Plant> plants = ArrayList<Plant>;

    public Map(int mapSize)
    {
        this.mapSize = mapSize;
    }

    public GenerateMap()
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
    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }
    public removeAnimal(Animal animal)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        animals.remove(animals);
    }
    public addTourist(Tourist tourist)
    {
        tourists.Add(tourist);
    }

    public removeTourist(Tourist tourist)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        tourists.remove(tourist);
    }
    public void getAllTourists()
    {
        return tourists;
    }
        public addRanger(Ranger ranger)
    {
        rangers.Add(ranger);
    }
    public removeRanger(Ranger ranger)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        rangers.remove(ranger);
    }
    public void getAllRangers()
    {
        return rangers;
    }

    public addPond(Pond pond)
    {
        ponds.Add(pond);
    }
    public removePond(Pond pond)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        ponds.remove(pond);
    }
    public void getAllPonds()
    {
        return ponds;
    }

    public addRoad(Road road)
    {
        roads.Add(road);
    }
    public removeRoad(Road road)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        roads.remove(road);
    }
    public void getAllRoads()
    {
        return roads;
    }

    //NO DISPLAY MAP FUNCTION ADDED BECUASE THIS IS PART OF THE VIEW #5


}