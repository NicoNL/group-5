using System;
using System.Collections.Generic;
using System.Numerics;

public class Road
{
    public Vector2 StartPosition { get; set; }
    public Vector2 EndPosition { get; set; }
    public float Length { get; private set; }
    public bool IsNavigable { get; private set; }
    public List<Road> ConnectedRoads { get; private set; }

    public Road(Vector2 startPosition, Vector2 endPosition, bool isNavigable = true)
    {
        StartPosition = startPosition;
        EndPosition = endPosition;
        Length = CalculateDistance();
        IsNavigable = isNavigable;
        ConnectedRoads = new List<Road>();
    }

    // Connects this road to another road
    public void ConnectTo(Road road)
    {
        if (road != null && !ConnectedRoads.Contains(road))
        {
            ConnectedRoads.Add(road);
            road.ConnectedRoads.Add(this); // Mutual connection
        }
    }

    // Returns the list of connected roads
    public List<Road> GetConnectedRoads()
    {
        return ConnectedRoads;
    }

    // Checks if the road is navigable and has connections
    public bool IsValidPath()
    {
        return IsNavigable && ConnectedRoads.Count > 0;
    }

    // Calculates the distance between the start and end positions
    public float CalculateDistance()
    {
        return Vector2.Distance(StartPosition, EndPosition);
    }

    // Allows navigation on this road
    public void AllowNavigation()
    {
        IsNavigable = true;
    }

    // Blocks navigation on this road
    public void BlockNavigation()
    {
        IsNavigable = false;
    }
}
