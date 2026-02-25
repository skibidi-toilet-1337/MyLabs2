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
      //AnimalManager.Instance.showAnimals();
      //AnimalManager.Instance.showAnimalByIndex(1);

      string option, strIndex;

      while (true) {
        AnimalManager.Instance.showMenu();
        option = Console.ReadLine();

        switch (option) {
          case "0":
            AnimalManager.Instance.showAnimals();
            break;
          case "1":
            Console.Write("Enter index: ");
            strIndex = Console.ReadLine();
            if (int.TryParse(strIndex, out int index)) {
              AnimalManager.Instance.showAnimalByIndex(index);
            } else {
              Console.WriteLine("Wrong index!!!");
            }
              break;
          case "2":
            AnimalManager.Instance.addAnimalManually();
            break;
          case "3":
            return;
        }
      }
    }
  }
}
