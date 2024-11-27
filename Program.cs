namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int e = 1; e <= 100; e++)
            {
                if (e % 3 == 0 && e % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (e % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (e % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
