using System;

namespace classIntro
{
  class Program
  {
    static void Main(string[] args)
    {
      Car myFordBronco = new Car(40000, "Ford", "Bronco", 1982);

      Car mySubaru = new Car(66000);
      mySubaru.Make = "Subaru";
      mySubaru.Model = "Forester";
      mySubaru.Year = 1982;

      myFordBronco.Drive(9999);

      Console.WriteLine($"Bronco needs service: {myFordBronco.needsMaintenance}");
      myFordBronco.Drive(60);
      Console.WriteLine($"Bronco needs service: {myFordBronco.needsMaintenance}");
      myFordBronco.Service();
      Console.WriteLine($"Bronco needs service: {myFordBronco.needsMaintenance}");
      myFordBronco.Service(true);




    }
  }
}
