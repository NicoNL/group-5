using System.Numerics;
public class Pond
{
    private float waterLevel;
    private int dryingRate;
    private Vector2 location;

    public Pond(int dryingRate, Vector2 location)
    {
        this.dryingRate = dryingRate;
        this.location = location;
    }

    public void setWaterLevel(float waterLevel){
        this.waterLevel = waterLevel;
    }
    public float getWaterLevel(){
        return waterLevel;
    }
    public void decreaseWaterLevel(float waterLevel){
        this.waterLevel -= waterLevel;
    }
    public bool isDry(){
        return waterLevel <= 0;
    }
}