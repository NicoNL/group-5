using System.Collections.Generic;

public class ShopManager
{
    // INSTEAD OF USING A STRING WE USE THE CONTENT OF THE ENUMS
    private Dictionary<Species, double> availableAnimals;
    private Dictionary<PlantType, double> availablePlants;
    private int availablePonds;
    private float pondPrice;
    private GameManager gameManager;

    public ShopManager()
    {
        availableAnimals = new Dictionary<AnimalType, double>();
        pondPrice = 100;
    }
    public void buyAnimal(Species type)
    {
        if (canAfford(availableAnimals[type]))
        {
            deductFunds(availableAnimals[type]);
            //LOGIC TO ADD A NEW ANIMAL
        }
    }
    public void buyPlant(PlanType type)
    {
        if (canAfford(availablePlants[type]))
        {
            deductFunds(availablePlants[type]);
            //LOGIC TO ADD A NEW ANIMAL
        }
    }
    public void buyPond()
    {
        if (availablePonds >= 1)
        {
            if (canAfford(pondPrice))
            {
                deductFunds(pondPrice);
                //LOGIC TO ADD A NEW ANIMAL
            }

        }
    }
    public sellAnimal(Animal animal)
    {
        addFunds(availableAnimals[animal.getType()]);
    }
    public sellPlant(Plant plant)
    {
        addFunds(availablePlants[plant.getType()]);
    }
    public void deductFunds(double amount)
    {
        gameManager.increaseCapital(amount);
    }
    public void addFunds(double amount)
    {
        gameManager.decreaseCapital(amount);
    }
    //THIS METHOD CAN BE ELIMINATED BUT NEED TO BE DISCUSSED #12
    public bool canAfford(double price)
    {
        int capital = gameManager.getCurrentCapital();
        return capital - price < 0;
    }
}