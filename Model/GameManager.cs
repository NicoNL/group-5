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
        mapAddAnimal.Add(animal);
    }
    public List<Animal> getAllAnimals()
    {
        return Map.getAllAnimals();
    }
    public addTourist(Tourist tourist)
    {
        map.AddTourist(tourist);
    }
    public removeTourist(Tourist tourist)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        map.removeTourist(tourist);
    }
    public void getAllTourists()
    {
        return map.getAllTourists();
    }

    public addRanger(Ranger ranger)
    {
        map.AddRanger(ranger);
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
        map.AddPon(pond);
    }
    public removePond(Pond pond)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        map.removePond(pond);
    }
    public void getAllPonds()
    {
        return map.getAllPonds;
    }

    public addRoad(Road road)
    {
        map.addRoad(road);
    }
    public removeRoad(Road road)
    {
        //PLACEHOLDER FOR HABLDING NOT FOUND
        map.removeRoad(road);
    }
    public void getAllRoads()
    {
        return map.getAllRoads();
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
    public int getDay(){
        return date[0];
    }
    public int getMonth(){
        return date[1];
    }
    public int getYear(){
        return date[2];
    }
}