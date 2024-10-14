namespace KT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Property[] properties = new Property[10];
            properties[0] = new Appartment(5000000, 30);
            properties[1] = new Appartment(5000000, 150);
            properties[2] = new Appartment(5000000, 400);
            properties[3] = new CountryHouse(902000000, 500);
            properties[4] = new CountryHouse(900000000, 299);
            properties[5] = new Car(10000000,45);
            properties[6] = new Car(20000000,90);
            properties[7] = new Car(80000000,70);
            properties[8] = new Boat(1020000000,70);
            properties[9] = new Boat(110000000,110);
            for (int i = 0;i< properties.Length; i++)
            {
                Console.WriteLine(properties[i].ToString());
            }
        }
    }
}
