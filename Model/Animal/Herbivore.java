package Model.Animal;


public class Herbivore extends Animal {
    public Herbivore(int lifespanLimit, int consumpLevel, double price, Species species) {
        super(lifespanLimit, consumpLevel, price, AnimalType.HERBIVORE, species);
    }
} 