public class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>(); // Arabaları saklamak için liste
        string userResponse;

    MainMenu:
        Console.Write("Bir araba üretmek ister misiniz? (E/H): ");
        userResponse = Console.ReadLine().Trim().ToLower();

        if (userResponse == "e")
        {
            string serialNumber, brand, model, color;
            int doorCount;

            Console.Write("Seri Numarası: ");
            serialNumber = Console.ReadLine();

            Console.Write("Marka: ");
            brand = Console.ReadLine();

            Console.Write("Model: ");
            model = Console.ReadLine();

            Console.Write("Renk: ");
            color = Console.ReadLine();

        DoorCountEntry:
            try
            {
                Console.Write("Kapı Sayısı: ");
                string doorCountInput = Console.ReadLine();
                doorCount = int.Parse(doorCountInput);

                // Başarılı giriş, döngüden çık
                goto CreateCar;
            }
            catch (FormatException)
            {
                Console.WriteLine("Hatalı giriş! Kapı sayısı için lütfen sayısal bir değer giriniz.");
                goto DoorCountEntry;
            }

        CreateCar:
            Car newCar = new Car(serialNumber, brand, model, color, doorCount);
            cars.Add(newCar); // Arabayı listeye ekle

            Console.WriteLine("Araba başarıyla üretildi!");

            goto MainMenu;
        }
        else if (userResponse != "h")
        {
            Console.WriteLine("Geçersiz cevap! Lütfen 'E' veya 'H' ile yanıt veriniz.");
            goto MainMenu;
        }

        // Üretilen tüm arabaları yazdır
        GetAllCars(cars);

        Console.WriteLine("Program sonlandı.");
    }

    // Arabaları listeleyen metod
    static void GetAllCars(List<Car> cars)
    {
        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var car in cars)
        {
            Console.WriteLine($"Seri Numarası: {car.SerialNumber}, Marka: {car.Brand}, Model: {car.Model}, Renk: {car.Color}, Kapı Sayısı: {car.DoorCount}, Üretim Tarihi: {car.ProductionDate}");
        }
    }
}