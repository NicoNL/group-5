public class Herbivore : Animal {
    public Herbivore(int lifespanLimit, int consumpLevel, double price, Species species) 
    :  base(lifespanLimit, consumpLevel, price, AnimalType.HERBIVORE, species)
    { 
    }
}
