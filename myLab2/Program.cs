using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLab2 {
  internal class Program {
    static void Main(string[] args) {
      Fish animal = new Fish();
      animal.age = 10;
      animal.nickname = "Skibidi";
      animal.waterType = "salty";
      AnimalManager.Instance.addAnimal(animal);

      Mammal mammal = new Mammal();
      mammal.hasFur = true;
      mammal.age = 20;
      mammal.nickname = "Lala";

      AnimalManager.Instance.addAnimal(mammal);
      AnimalManager.Instance.showAnimals();
      //AnimalManager.Instance.showAnimalByIndex(1);

      while (true) {
        AnimalManager.Instance.showMenu();

      }

      Console.ReadKey();
    }
  }
}
