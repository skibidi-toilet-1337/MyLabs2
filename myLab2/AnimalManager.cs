using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLab2 {
  public sealed class AnimalManager {
    private static AnimalManager instance = null;
    private static readonly object padlock = new object();

    AnimalManager() {
      List<Animal> list = new List<Animal>();

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
