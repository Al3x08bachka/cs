internal class Program
{
    private static void Main(string[] args)
    {
        for(int i = 1000; i<= 9999; i++)
            {
            int a = ((i % 10) + ((i % 100) / 10) + ((i / 100) % 10) + (i / 1000));
            if (a >= 10 && a <= 99 && a % 2 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}