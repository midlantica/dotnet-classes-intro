namespace ClassesIntro
{
  public class Car {

    // Private Fields
    private int _milesDriven;
    public string Color { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(int Year, int _milesDriven)
    {
      Year = 2020;
      _milesDriven = 10_000;
    }

    public string Description
    {
      get
      {
        return $"Car: {Year} {Color} {Make} {Model} {GetOdometer()}";
      }
    }

    // Methods
    public void Drive(int miles)
    {
      _milesDriven += miles;
    }

    public int GetOdometer()
    {
      return _milesDriven;
    }

  }
}
