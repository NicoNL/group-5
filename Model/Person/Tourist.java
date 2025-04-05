package Model.Person;

import Model.Animal.Animal;

public class Tourist extends Person {
    private double budget;
    private double joyLevel;

    public Tourist(String name, PersonType type) {
        super(name, type);
        this.joyLevel = 100;
    }

    public void takePhoto(Animal animal) {
        // TODO: Implement photo taking logic
    }

    public void observeAnimals() {
        // TODO: Implement animal observation logic
    }

    public void increaseJoy(double amount) {
        if (joyLevel + amount <= 100) {
            joyLevel += amount;
        }
    }

    public void decreaseJoy(double amount) {
        if (joyLevel - amount >= 0) {
            joyLevel -= amount;
        }
    }

    public void spendMoney(double amount) {
        budget -= amount;
    }

    public double getJoyLevel() {
        return joyLevel;
    }
} 