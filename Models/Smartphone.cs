namespace phone.Models;

public abstract class Smartphone
{
    private string _model = string.Empty;
    private string _imei = string.Empty;
    private int _memory;

    public string Number { get; private set; }
    public string Model => _model;
    public string IMEI => _imei;
    public int Memory => _memory;

    // Constructor with validation
    protected Smartphone(string number, string model, string imei, int memory)
    {
        if (string.IsNullOrWhiteSpace(number))
            throw new ArgumentException("The phone number cannot be empty.", nameof(number));

        if (string.IsNullOrWhiteSpace(model))
            throw new ArgumentException("The model cannot be empty.", nameof(model));

        if (string.IsNullOrWhiteSpace(imei))
            throw new ArgumentException("The IMEI cannot be empty.", nameof(imei));

        if (memory <= 0)
            throw new ArgumentException("Memory must be greater than zero.", nameof(memory));

        Number = number;
        _model = model;
        _imei = imei;
        _memory = memory;
    }

    public void MakeCall() {
        Console.WriteLine("Calling...");
    }
    public void ReceiveCall()
    {
        Console.WriteLine("Recieve call...");
    }

    public abstract void InstallApp(string appName);
}