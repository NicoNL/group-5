using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public class GameManager
{
    private double gameTime;
    // DATE is and array of 3 integers containing the format dd/mm/yyyy
    private int[] date;
    private double capital;

    //Animal lists are now in the gameManager because it contains the elemetns of the player
    private ArrayList<Animal> animals = ArrayList<Animal>;
    private ArrayList<Tourist> tourists = ArrayList<Tourist>;
    private ArrayList<Ranger> rangers = ArrayList<Ranger>;
    private ArrayList<Pond> ponds = ArrayList<Pond>;
    private ArrayList<Road> roads = ArrayList<Road>;
    private GameState gameState;
    // MODE is an enum containg the three lvls of difficulty
    private Mode difficulty;
    private Map map;

    public GameManager(int[] date, double capital, Mode difficulty)
    {
        this.date = date;
        this.capital = capital;
        this.difficulty = difficulty;

    }

    public void startNewGame()
    {
        //PLACEHOLDER
    }
    public void resumeGame()
    {
        //PLACEHOLDER
    }
    public void saveGame()
    {
        //PLACEHOLDER
    }
    public void loadGame()
    {
        //PLACEHOLDER
    }
    public void updateGameTime()
    {
        //Placeholder to use next day 
    }
    //ADDED SOME FUNCTIONS FOR THE BEHAVIOR OF THE TIME,
    //FOR SIMPLICIITY I CONSIDER EVERY MONTH AS A 30-DAY MONTH
    private void nextDay()
    {
        date[0]++;
        if (date[1] > 30)
        {
            nextMonth();
            date[0] = 0;
        }
    }
    private void nextMonth()
    {
        date[1]++;
        if (date[1] > 12)
        {
            date[2]++;
            date[1] = 1;
        }
    }
    public bool isNight()
    {
        //PLACEHOLDER
    }
    public void increaseCapital(double amount)
    {
        capital -= amount;
    }

    public void decreaseCapital(double amount)
    {
        capital -= amount;
    }
    public getCurrentCapital()
    {
        return capital;
    }
    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }
    //ADDED COUNTS 
    public int carnivoreCount()
    {
        return animals.stream().filter(animal->animal instanceof Carnivore).count();
    }
    public int herbivoreCount()
    {
        return animals.stream().filter(animal->animal instanceof Herbivore).count();
    }
    public int animalCount()
    {
        return animals.Count();
    }
    public List<Animal> getAllAnimals()
    {
        return animals;
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
    public bool checkWinningCondition()
    {

    }
    public bool checkWinningCondition()
    {

    }
    public gameState getCurrentState()
    {
        return gameState;
    }
    public void setGameState(GameState state)
    {
        gameState = state;
    }
}