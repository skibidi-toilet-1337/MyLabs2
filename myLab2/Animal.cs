using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLab2 {
  public abstract class Animal {
    public string nickname = " ";
    public int age = 0;
    public string habitat = " ";
    public string foodType = " ";
    public string color = " ";
    public virtual void GetInfo() {
      Console.WriteLine($"Nickname: {nickname}, Age: {age}, Habitat: {habitat}, Food type: {foodType}, Color: {color}");
      Console.ReadKey();
    }
  }
}
