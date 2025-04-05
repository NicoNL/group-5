package Controller;

import Model.Animal.Animal;
import Model.Animal.Carnivore;
import Model.Animal.Herbivore;
import Model.Plant.Plant;
import Model.Plant.PlantType;
import Model.Scenery.Pond;
import java.awt.geom.Point2D;
import java.util.*;

public class AnimalController {
    private List<Animal> animals;
    private List<Herbivore> herbivores;
    private List<Carnivore> carnivores;
    private Map<String, List<Animal>> animalGroups;
    private float hungerThreshold;
    private float thirstThreshold;
    private float reproductionCooldown;
    private float movementSpeedMultiplier;
    private List<Animal> deadAnimals;

    public AnimalController(float hungerThreshold, float thirstThreshold, 
                          float reproductionCooldown, float movementSpeedMultiplier) {
        this.animals = new ArrayList<>();
        this.herbivores = new ArrayList<>();
        this.carnivores = new ArrayList<>();
        this.animalGroups = new HashMap<>();
        this.deadAnimals = new ArrayList<>();
        this.hungerThreshold = hungerThreshold;
        this.thirstThreshold = thirstThreshold;
        this.reproductionCooldown = reproductionCooldown;
        this.movementSpeedMultiplier = movementSpeedMultiplier;
    }

    public AnimalController() {
        this(50f, 50f, 10f, 1f);
    }

    public void addAnimal(Animal animal) {
        animals.add(animal);
        if (animal instanceof Herbivore) {
            herbivores.add((Herbivore) animal);
        }
        if (animal instanceof Carnivore) {
            carnivores.add((Carnivore) animal);
        }

        animalGroups.computeIfAbsent(animal.getGroup(), k -> new ArrayList<>());
        animalGroups.get(animal.getGroup()).add(animal);
    }

    public void removeAnimal(Animal animal) {
        animals.remove(animal);
        if (animal instanceof Herbivore) {
            herbivores.remove((Herbivore) animal);
        }
        if (animal instanceof Carnivore) {
            carnivores.remove((Carnivore) animal);
        }

        if (animalGroups.containsKey(animal.getGroup())) {
            animalGroups.get(animal.getGroup()).remove(animal);
        }
    }

    public Animal getAnimalById(int id) {
        return id >= 0 && id < animals.size() ? animals.get(id) : null;
    }

    public void updateAnimals() {
        for (Animal animal : animals) {
            if (!animal.isAlive()) {
                handleAnimalDeath(animal);
                continue;
            }

            if (checkHungerLevel(animal)) {
                findNearestFoodSource(animal);
            }
            if (checkThirstLevel(animal)) {
                findNearestWaterSource(animal);
            }
        }

        removeDeadAnimals();
        handleReproduction(animals);
        updateAnimalMovement();
    }

    public void moveAnimal(Animal animal, float x, float y) {
        animal.move(new Point2D.Double(x, y));
    }

    public Pond findNearestWaterSource(Animal animal) {
        // Placeholder logic, replace with actual logic
        return new Pond(1, new Point2D.Float(0, 0));
    }

    public Plant findNearestFoodSource(Animal animal) {
        // Placeholder logic, replace with actual logic
        return new Plant(PlantType.GRASS) {
            // Anonymous subclass since Plant is abstract
        };
    }

    public void updateAnimalMovement() {
        Random random = new Random();
        for (Animal animal : animals) {
            float randomX = random.nextFloat() * 100;
            float randomY = random.nextFloat() * 100;
            moveAnimal(animal, randomX, randomY);
        }
    }

    public boolean checkHungerLevel(Animal animal) {
        return animal.getStatus().contains("Hunger: ") && 
               Integer.parseInt(animal.getStatus().split("Hunger: ")[1].split(",")[0]) > hungerThreshold;
    }

    public boolean checkThirstLevel(Animal animal) {
        return animal.getStatus().contains("Thirst: ") && 
               Integer.parseInt(animal.getStatus().split("Thirst: ")[1].split(",")[0]) > thirstThreshold;
    }

    public void feedAnimal(Animal animal, Plant food) {
        // Since eat is private in Animal class, we'll need to implement this differently
        // This is a placeholder - you might want to add a public method in Animal class
        System.out.println("Feeding animal with " + food.getType());
    }

    public void giveWaterToAnimal(Animal animal, Pond pond) {
        // Since drink is private in Animal class, we'll need to implement this differently
        // This is a placeholder - you might want to add a public method in Animal class
        System.out.println("Giving water to animal from pond at " + pond.getWaterLevel());
    }

    public boolean canReproduce(Animal animal) {
        return animal.isCanReproduce();
    }

    public void handleReproduction(List<Animal> animals) {
        for (int i = 0; i < animals.size(); i++) {
            for (int j = i + 1; j < animals.size(); j++) {
                if (canReproduce(animals.get(i)) && canReproduce(animals.get(j))) {
                    // Since reproduce is not implemented in Animal class, this is a placeholder
                    System.out.println("Animals attempting to reproduce");
                }
            }
        }
    }

    public void handleAnimalDeath(Animal animal) {
        if (!animal.isAlive() && !deadAnimals.contains(animal)) {
            deadAnimals.add(animal);
        }
    }

    public void removeDeadAnimals() {
        for (Animal animal : deadAnimals) {
            removeAnimal(animal);
        }
        deadAnimals.clear();
    }
} 