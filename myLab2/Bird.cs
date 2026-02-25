using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLab2 {
  internal class Bird : Animal {
    public bool wingSpan;
    public override void GetInfo() {
      Console.WriteLine($"Nickname: {nickname}, Age: {age}, Habitat: {habitat}, Food type: {foodType}, Color: {color}, Wing Span: {wingSpan}");
      Console.ReadKey();
    }

  }
}
