namespace vector3_math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3 x = new Vector3(-1, 2, 5);
            Vector3 y = new Vector3(2, 7, 17);


            Console.WriteLine($"Vector X = {x}");
            Console.WriteLine($"Vector X magnitude = {x.Magnitude}");
            Console.WriteLine($"Vector X normalized = {x.Normalized}");


            Console.WriteLine($"Vector Y = {y}");
            Console.WriteLine($"Vector Y magnitude = {y.Magnitude}");
            Console.WriteLine($"Vector Y normalized = {y.Normalized}");



            Console.WriteLine($"Dot product of X & Y: " + Vector3.DotProduct(x, y));

            Console.WriteLine($"Cross product of X & Y: " + Vector3.CrossProduct(x, y));
        }
    }
}