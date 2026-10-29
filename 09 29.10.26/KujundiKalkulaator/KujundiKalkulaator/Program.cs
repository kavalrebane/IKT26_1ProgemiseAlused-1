namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Ruudu sees asub ring. Ringi raadius on 3 ühikut
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt

            int roundRadius = 3;
            //raadius * 2

            int diameter = roundRadius * 2;

            //ruudu pindala on a ruudus
            double squareArea = Math.Pow(diameter, 2);

            //ümbermõõt 4 * a
            double squarePerimeter = 4 * diameter;


            Console.WriteLine("Ruudu pindala: " + squareArea);
            Console.WriteLine("Ruudu ümbermõõt: " + squarePerimeter);

            //arvuta ringi pibdala ja ümbermõõt


            //ringi pindala on pii raadius ruudus
            double circlearea = Math.PI * roundRadius * roundRadius;

            //ringi ümbermõõt on 2 * pii * raadius

            double circlePerimeter = 2 * Math.PI * roundRadius;

            Console.WriteLine("ringi pindala: " + circlearea);
            Console.WriteLine("ringi ümbermõõt: " + circlePerimeter);


        }
    }
}
