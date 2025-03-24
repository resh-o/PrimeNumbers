namespace prjCountingPrimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bStop = false;

            while (!bStop)
            {
                Console.Write("\n*************************");
                Console.Write("\nEnter a number: ");
                String strInput = Console.ReadLine();

                if (strInput.Equals("="))
                {
                    bStop = true;
                    break;
                }

                if (int.TryParse(strInput, out int n))
                {
                    Calculations.SieveOfEratosthenes(n);
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
    }
}
