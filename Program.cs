using System;
using Faker;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            var nimi = Name.First();
            var sukunimi = Name.Last();
            var osoite = Address.StreetAddress(true);
            var henkilotunnus = GeneroiHenkilotunnus();

            Console.WriteLine($"Nimi ja Sukunimi: {nimi} {sukunimi}");
            Console.WriteLine($"Osoite: {osoite}");
            Console.WriteLine($"Henkilötunnus: {henkilotunnus}");
            Console.WriteLine("------------------------------------");
        }
    }


    private static string GeneroiHenkilotunnus()
    {
        var random = new Random();
        var kirjain = (char)random.Next('A', 'Z' + 1);
        var numerot = $"{random.Next(1000, 9999)} {random.Next(1000, 9999)}";
        return $"{kirjain} {numerot}";
    }
}

