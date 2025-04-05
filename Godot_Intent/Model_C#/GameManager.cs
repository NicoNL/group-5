using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public class GameManager
{
    private double gameTime;
    // INFO: Fix this calculation issue #1    
    private int[] date;
    private double capital;

    // INFO: Animal lists are now in the gameManager because it contains the elemetns of the player  #2
    private GameState gameState;
    // INFO :  MODE is an enum containg the three lvls of difficulty #3
    private Mode difficulty;
    private Map map;

    public GameManager(int[] date, double capital, Mode difficulty)
    {
        this.date = date;
        this.capital = capital;
        this.difficulty = difficulty;
        gameState = new GameState();
        map = new Map(4);

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
    // INFO : ADDED SOME FUNCTIONS FOR THE BEHAVIOR OF THE TIME, FOR SIMPLICIITY I CONSIDER EVERY MONTH AS A 30-DAY MONTH # 3
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
        return false;
    }
    public void increaseCapital(double amount)
    {
        capital += amount;
    }
    //THIS METHOD RETURNS A BOOL TO CHECK IF THERE IS ENOUGH CAPITAL
    //CHECK SHOP MANAGER FOR FURTHER UNDERSTANDING
    public bool decreaseCapital(double amount)
    {
        if (capital - amount <= 0)
        {
            capital -= amount;
        }
        else
        {
            return false;
        }
        return true;
    }
    public double getCurrentCapital()
    {
        return capital;
    }
    public void AddAnimal(Animal animal)
    {
        map.addAnimal(animal);
    }
    public List<Animal> getAllAnimals()
    {
        return map.getAllAnimals();
    }
    public void addTourist(Tourist tourist)
    {
        map.addTourist(tourist);
    }
    public void removeTourist(Tourist tourist)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        map.removeTourist(tourist);
    }
    public List<Tourist> getAllTourists()
    {
        return map.getAllTourists();
    }

    public void addRanger(Ranger ranger)
    {
        map.addRanger(ranger);
    }
    public void removeRanger(Ranger ranger)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        map.removeRanger(ranger);
    }
    public List<Ranger> getAllRangers()
    {
        return map.getAllRangers();
    }

    public void addPond(Pond pond)
    {
        map.addPond(pond);
    }
    public void removePond(Pond pond)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        map.removePond(pond);
    }
    public List<Pond> getAllPonds()
    {
        return map.getAllPonds();
    }

    public void addRoad(Road road)
    {
        map.addRoad(road);
    }
    public void removeRoad(Road road)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        map.removeRoad(road);
    }
    public List<Road> getAllRoads()
    {
        return map.getAllRoads();
    }
    // public bool checkWinningCondition()
    // {

    // }
    // public bool checkWinningCondition()
    // {

    // }
    public GameState getCurrentState()
    {
        return gameState;
    }
    public void setGameState(GameState state)
    {
        gameState = state;
    }
    public int getDay()
    {
        return date[0];
    }
    public int getMonth()
    {
        return date[1];
    }
    public int getYear()
    {
        return date[2];
    }
}