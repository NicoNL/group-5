public abstract class Plant{
    private PlantType type;
    private float health;
    //PRICE IS NOT ADDED BECUASE THIS IS PART OF SHOP MANAGER

    public Plant(PlantType type){
        this.type = type;
    }
    public PlantType getType(){
        return type;
    }
    public void reduceHealth(float amount){
        health -= amount;
    }

}