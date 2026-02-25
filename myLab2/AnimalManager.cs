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
