using System.Collections.Generic;

public class ShopManager
{
    // INSTEAD OF USING A STRING WE USE THE CONTENT OF THE ENUMS
    private Dictionary<Species, double> availableAnimals;
    private Dictionary<PlantType, double> availablePlants;
    private int availablePonds;
    private int availablePoacher;
    private int availableRanger;
    private float poacherPrice;
    private float rangerPrice;
    private float pondPrice;
    private float roadPrice;
    private float jeepPrice;
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
        if (availablePonds >= 1 && canAfford(pondPrice))
        {
            deductFunds(pondPrice);
            //LOGIC TO ADD A NEW ANIMAL
        }
    }
    public void buyJeep()
    {
        if (canAfford(jeepPrice))
        {
            deductFunds(jeepPrice);

        }
    }
    public void buyRoad()
    {
        if (canAfford(roadPrice))
        {
            deductFunds(roadPrice);
        }
    }
    public void hireRanger()
    {
        if (availableRanger >= 1 && canAfford(rangerPrice))
        {
            deductFunds(rangerPrice);
            //LOGIC TO ADD NEW ANIMAL
        }

    }
    public void hirePoacher()
    {
        if (availablePoacher >= 1 && canAfford(poacherPricePrice))
        {
            deductFunds(poacherPricePrice);
            //LOGIC TO ADD NEW ANIMAL
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
        gameManager.decreaseCapital(amount);
    }
    public void addFunds(double amount)
    {
        gameManager.increaseCapital(amount);
    }
    //THIS METHOD CAN BE ELIMINATED BUT NEED TO BE DISCUSSED #12
    public bool canAfford(double price)
    {
        int capital = gameManager.getCurrentCapital();
        return capital - price < 0;
    }
}