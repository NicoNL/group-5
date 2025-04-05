package Model.Transportation;

import java.util.ArrayList;
import java.util.List;

import Model.Person.Tourist;

public class Jeep {
    private int capacity;
    private List<Tourist> passengers = new ArrayList<>();

    public Jeep(int capacity) {
        this.capacity = capacity;
    }

    public void move(String direction) {
        // TODO: Implement movement logic
    }
} 