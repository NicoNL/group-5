using System.Threading;

public class Carnivore : Animal
{
    public Carnivore(int lifespanLimit, int consumpLevel, double price, Species species)
        : base(lifespanLimit, consumpLevel, price, AnimalType.CARNIVORE, species)
    {
    }
}
