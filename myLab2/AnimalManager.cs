using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLab2 {
  public sealed class AnimalManager {
    private static AnimalManager instance = null;
    private static readonly object padlock = new object();
    private static List<Animal> animalList;
    AnimalManager() {
      animalList = new List<Animal>();
    }

    public void addAnimal(Animal animal) {
      animalList.Add(animal);
    }

    public void showAnimals() { 
      foreach (Animal animal in animalList) {
        animal.GetInfo();
      }
    }

    public void showAnimalByIndex(int index) {
      animalList[index].GetInfo();
    }

    public void showMenu() {
      Console.WriteLine("Menu:\n0: Show animals\n1: Show animal by index\n2: Add new animal\n3: Exit");
      Console.Write("Select option: ");
    }
    public void addAnimalManually() {
      Console.WriteLine("Select type:\n0: Mammal\n1: Bird\n2: Fih\n3: Amphibian\n4: Reptile");
      string selectedType = Console.ReadLine();

      Console.Write("Nickname: ");
      string nickname = Console.ReadLine();

      Console.Write("Age: ");
      int age = 0;
      if (int.TryParse(Console.ReadLine(), out int inAge)) { 
        age = inAge;
      }

      Console.Write("Habitat: ");
      string habitat = Console.ReadLine();

      Console.Write("Food type: ");
      string foodType = Console.ReadLine();

      Console.Write("Color: ");
      string color = Console.ReadLine();

      switch (selectedType) {
        case "0":
          Console.Write("Has fur? Type Y: ");
          bool hasFur = Console.ReadLine().ToLower() == "y";
          addAnimal(new Mammal(nickname, age, habitat, foodType, color, hasFur));
          break;

        case "1":
          Console.Write("Wing span in meters: ");
          float wingSpan = 0;
          if (float.TryParse(Console.ReadLine(), out float inWingSpan)) {
            wingSpan = inWingSpan;
          }

          addAnimal(new Bird(nickname, age, habitat, foodType, color, wingSpan));
          break;

        case "2":
          Console.Write("Water type: ");
          string waterType = Console.ReadLine();
          addAnimal(new Fish(nickname, age, habitat, foodType, color, waterType));
          break;

        case "3":
          Console.Write("Skin moisture in points (0 to inf): ");
          int skinMoisture = int.Parse(Console.ReadLine());
          addAnimal(new Amphibian(nickname, age, habitat, foodType, color, skinMoisture));
          break;

        case "4":
          Console.Write("Is venomous? Type Y: ");
          bool isVenomous = Console.ReadLine().ToLower() == "y";
          addAnimal(new Reptile(nickname, age, habitat, foodType, color, isVenomous));
          break;
      }
    }
    public static AnimalManager Instance {
      get {
        lock (padlock) {
          if (instance == null) { 
            instance = new AnimalManager();
          }
          return instance;
        }
      }
    }
  }
}
