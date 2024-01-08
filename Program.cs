namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 101; i++)
            {
                if (CheckNumber.IsDivisibleBy3And5(i))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (CheckNumber.IsDivisibleBy3(i))
                {
                    Console.WriteLine("Fizz");
                }
                else if (CheckNumber.IsDivisibleBy5(i))
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
