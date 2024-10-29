namespace Set1Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introdu un numar n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if( n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
                    
        }
    }
}
