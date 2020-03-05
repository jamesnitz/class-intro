

namespace classIntro
{
  public class Car
  {
    //Fields don't have get and set and are typically private
    private int _milesDriven = 0;
    //PROPERTIES have get set. Typically public
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool needsMaintenance { get; set; } = false;
    public bool isClean { get; set; } = false;
    //computed property. READ ONLY. can't be set
    public string Description
    {
      get
      {
        return $"{Year} {Make} {Model}";
      }
    }

    //METHOD
    public void Drive(int miles)
    {
      _milesDriven += miles;

      if (_milesDriven > 10000)
      {
        needsMaintenance = true;
      }
    }

    public void Service()
    {
      needsMaintenance = false;
    }
    //method overloading. Shares a method name, but has different arguments
    public void Service(bool addCleaningService)
    {
      needsMaintenance = false;
      if (addCleaningService)
      {
        isClean = addCleaningService;
      }
    }
    //CONSTRUCTOR it doesn't have  a return type
    // and the name of the method is the same as the class
    //Runs whenever a new Car is run!
    public Car(int milesDriven)
    {
      _milesDriven = milesDriven;
    }

    public Car(int milesDriven, string make, string model, int year)
    {
      _milesDriven = milesDriven;
      Make = make;
      Model = model;
      Year = year;

    }

  }
}