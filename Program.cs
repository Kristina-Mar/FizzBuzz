namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                CheckNumber.CheckDivisibility(i);
                Console.WriteLine(CheckNumber.Line);
                CheckNumber.Line = string.Empty;
            }
        }
    }
}
