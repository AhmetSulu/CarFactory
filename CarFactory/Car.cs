public class Car
{
    public DateTime ProductionDate { get; set; }
    public string SerialNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int DoorCount { get; set; }

    // Parametreli constructor
    public Car(string serialNumber, string brand, string model, string color, int doorCount)
    {
        ProductionDate = DateTime.Now; // Üretim tarihi otomatik olarak atanır
        SerialNumber = serialNumber;
        Brand = brand;
        Model = model;
        Color = color;
        DoorCount = doorCount;
    }
}