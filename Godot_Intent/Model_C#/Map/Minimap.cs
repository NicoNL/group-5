using System.Collections;
using System.Numerics;
using System.Collections.Generic;
public class Minimap
{
    private Map map;
    private int size;
    private float zoomLevel;

    //REMOVE PLAYER POSITION BECUASE PLAYER IS NOT AN ENTITY,
    //JUST THE PLAYER MOVING THE MOUSE AROUND THE SCREEN
    // Added Lists by type of entities # 7
    private List<Animal> visibleAnimals = new List<Animal>();
    private List<Plant> visiblePlants = new List<Plant>();


    public Minimap(Map map)
    {
        this.map = map;
        this.zoomLevel = 0;
    }
    //HIGHLIGHTED AREA WAS NOT ADDED BECUASE IS NOT CLEAR #8

    public void updateMinimap()
    {
        //PLACEHOLDER
    }
    public void zoomIn()
    {
        zoomLevel += 1;
        updateMinimap();
    }
    public void zoomOut()
    {
        zoomLevel -= 1;
        updateMinimap();
    }
    //ClickOnMINIMAP WAS NOT ADDED BECUASE IS A VIEW FUNCTION #9
    //Pan Method was not added bcause is a view function #10
}