public class Program
{
    static void Main(string[] args)
    {
        List<Araba> arabalar = new List<Araba>();
        string kullaniciCevabi;

    AnaMenu:
        Console.Write("Araba üretmek istiyor musunuz? (E/H): ");
        kullaniciCevabi = Console.ReadLine().Trim().ToLower();

        if (kullaniciCevabi == "e")
        {
            string seriNumarasi, marka, model, renk;
            int kapiSayisi;

            Console.Write("Seri Numarası: ");
            seriNumarasi = Console.ReadLine();

            Console.Write("Marka: ");
            marka = Console.ReadLine();

            Console.Write("Model: ");
            model = Console.ReadLine();

            Console.Write("Renk: ");
            renk = Console.ReadLine();

        KapıSayisiGirişi:
            try
            {
                Console.Write("Kapı Sayısı: ");
                string kapiSayisiInput = Console.ReadLine();
                kapiSayisi = int.Parse(kapiSayisiInput);

                // Başarılı giriş, döngüden çık
                goto ArabaOlustur;
            }
            catch (FormatException)
            {
                Console.WriteLine("Hatalı giriş! Kapı sayısı için lütfen sayısal bir değer giriniz.");
                goto KapıSayisiGirişi;
            }

        ArabaOlustur:
            Araba yeniAraba = new Araba(seriNumarasi, marka, model, renk, kapiSayisi);
            arabalar.Add(yeniAraba);

            Console.WriteLine("Araba başarıyla üretildi!");

            goto AnaMenu;
        }
        else if (kullaniciCevabi != "h")
        {
            Console.WriteLine("Geçersiz cevap! Lütfen 'E' veya 'H' ile yanıt veriniz.");
            goto AnaMenu;
        }

        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
        }

        Console.WriteLine("Program sonlandı.");
    }
}