using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLab2 {
  internal class Program {
    static void Main(string[] args) {
      Animal animal = new Animal();
      animal.age = 10;
      animal.nickname = "Skibidi";

      Mammal mammal = new Mammal();
      mammal.hasFur = true;
      mammal.age = 20;
      mammal.nickname = "Lala";
      animal.GetInfo();
      mammal.GetInfo();
    }
  }
}
