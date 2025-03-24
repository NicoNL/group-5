public class Tourist : Person
{
    private float budget;
    private float joyLevel;
    public Tourist(string name)
    {
        super(name);
        joyLevel = 100;
    }
    public void takePhoto(Animal animal)
    {

    }
    public void observeAnimals()
    {

    }
    public void increaseJoy(double amount)
    {
        if (joyLevel + amount <= 100)
        {

            joyLevel += joyLevel;
        }
    }
    public void decreaseJoy(double amount)
    {
        if (joyLevel - amount >= 0)
        {

            joyLevel -= joyLevel;
        }
    }
    public void spendMoney(double amount){
        budget -= amount;
    }
    //NO BUY ANIMAL ADDED BECAUSE ANIMALS CANT BE BOUGHT BY TOURISTS
    public double getJoyLevel(){
        return joyLevel;
    }
}