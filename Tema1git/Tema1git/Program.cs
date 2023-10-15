namespace Impartire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            x = Convert.ToInt32(Console.ReadLine("x="));
            y = Convert.ToInt32(Console.ReadLine("y="));
            z = x / y;

            if (y != 0 && x % y == 0)
            {
                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine("Impartirea nu poate fi efectuata");
            }
        }
    }
}