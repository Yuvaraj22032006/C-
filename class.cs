public class Car
{
    // Field
    private string _model;

    // Property
    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    // Constructor
    public Car(string model)
    {
        _model = model;
    }

    // Method
    public void StartEngine()
    {
        Console.WriteLine($"The {Model} engine has started.");
    }
}