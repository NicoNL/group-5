package Model;

import Model.Person.Person;
import Model.Person.PersonType;
import Model.Person.Poacher;
import Model.Person.Ranger;
import Model.Person.Tourist;

public class Main {
    public static void main(String[] args) {
        System.out.println("Hello World! Testing Person classes...");
        
        Person person = new Person("Generic Person", PersonType.RANGER);
        System.out.println("Created generic person: " + person.getName() + " of type " + person.getType());
        
        Poacher poacher = new Poacher("John Poacher", PersonType.POACHER);
        System.out.println("Created poacher: " + poacher.getName() + " of type " + poacher.getType());
        
        Ranger ranger = new Ranger("Jane Ranger", PersonType.RANGER);
        System.out.println("Created ranger: " + ranger.getName() + " of type " + ranger.getType());
        
        Tourist tourist = new Tourist("Bob Tourist", PersonType.TOURIST);
        System.out.println("Created tourist: " + tourist.getName() + " of type " + tourist.getType());
        System.out.println("Tourist joy level: " + tourist.getJoyLevel());
        
        tourist.increaseJoy(10);
        System.out.println("Tourist joy level after increase: " + tourist.getJoyLevel());
        
        tourist.decreaseJoy(5);
        System.out.println("Tourist joy level after decrease: " + tourist.getJoyLevel());
        
        System.out.println("All Person classes tested successfully!");
    }
} 