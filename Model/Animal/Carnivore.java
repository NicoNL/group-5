package Model.Animal;


public class Carnivore extends Animal {
    public Carnivore(int lifespanLimit, int consumpLevel, double price, Species species) {
        super(lifespanLimit, consumpLevel, price, AnimalType.CARNIVORE, species);
    }
} 