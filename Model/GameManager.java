package Model;  

import java.util.List;
import Model.Map.Map;
import Model.Scenery.Pond;
import Model.Animal.Animal;
import Model.Person.Tourist;
import Model.Person.Ranger;
import Model.Transportation.Road;

public class GameManager {
    private double gameTime;
    private int[] date;
    private double capital;
    private GameState gameState;
    private Mode difficulty;
    private Map map;

    public GameManager(int[] date, double capital, Mode difficulty) {
        this.date = date;
        this.capital = capital;
        this.difficulty = difficulty;
        this.gameState = new GameState();
        this.map = new Map(4);
    }

    public void startNewGame() {
        //PLACEHOLDER
    }

    public void resumeGame() {
        //PLACEHOLDER
    }

    public void saveGame() {
        //PLACEHOLDER
    }

    public void loadGame() {
        //PLACEHOLDER
    }

    public void updateGameTime() {
        //Placeholder to use next day 
    }

    private void nextDay() {
        date[0]++;
        if (date[1] > 30) {
            nextMonth();
            date[0] = 0;
        }
    }

    private void nextMonth() {
        date[1]++;
        if (date[1] > 12) {
            date[2]++;
            date[1] = 1;
        }
    }

    public boolean isNight() {
        return false;
    }

    public void increaseCapital(double amount) {
        capital += amount;
    }

    public boolean decreaseCapital(double amount) {
        if (capital - amount <= 0) {
            capital -= amount;
        } else {
            return false;
        }
        return true;
    }

    public double getCurrentCapital() {
        return capital;
    }

    public void addAnimal(Animal animal) {
        map.addAnimal(animal);
    }

    public List<Animal> getAllAnimals() {
        return map.getAllAnimals();
    }

    public void addTourist(Tourist tourist) {
        map.addTourist(tourist);
    }

    public void removeTourist(Tourist tourist) {
        //PLACEHOLDER FOR HANDLING NOT FOUND
        map.removeTourist(tourist);
    }

    public List<Tourist> getAllTourists() {
        return map.getAllTourists();
    }

    public void addRanger(Ranger ranger) {
        map.addRanger(ranger);
    }

    public void removeRanger(Ranger ranger) {
        //PLACEHOLDER FOR HANDLING NOT FOUND
        map.removeRanger(ranger);
    }

    public List<Ranger> getAllRangers() {
        return map.getAllRangers();
    }

    public void addPond(Pond pond) {
        map.addPond(pond);
    }

    public void removePond(Pond pond) {
        //PLACEHOLDER FOR HANDLING NOT FOUND
        map.removePond(pond);
    }

    public List<Pond> getAllPonds() {
        return map.getAllPonds();
    }

    public void addRoad(Road road) {
        map.addRoad(road);
    }

    public void removeRoad(Road road) {
        //PLACEHOLDER FOR HANDLING NOT FOUND
        map.removeRoad(road);
    }

    public List<Road> getAllRoads() {
        return map.getAllRoads();
    }

    public GameState getCurrentState() {
        return gameState;
    }

    public void setGameState(GameState state) {
        gameState = state;
    }

    public int getDay() {
        return date[0];
    }

    public int getMonth() {
        return date[1];
    }

    public int getYear() {
        return date[2];
    }
} 