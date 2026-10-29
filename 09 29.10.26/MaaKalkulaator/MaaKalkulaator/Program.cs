namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Meil on münt, mille diameeter on 25,75mm
            //Arvutada välja Maa ümbermõõt ja mitu münti
            //Mahub järjestiku ümber Maa
            //Arvutuses tohib kasutada ainult mündi diameetrit ja Maa raadiust

            double coinDiameter = 25.75; //mm
            double earthRadius = 6378000000;

            double calculationRadius = 2 * Math.PI * earthRadius;
            



            Console.WriteLine("2 * 3.14 * earthRadius = " + calculationRadius + " mm");

            double howManyCoins = calculationRadius / coinDiameter;

            Console.WriteLine("kahe euroseid läheb ümber maa{0:0}" + howManyCoins);


        }
    }
}
