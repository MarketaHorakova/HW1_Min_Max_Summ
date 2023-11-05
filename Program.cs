namespace HW1_Min_Max_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("How many elements for your array: ");
            int delkaPole;
            while (!int.TryParse(Console.ReadLine(), out delkaPole))
            {
                Console.WriteLine("Invalit input, try it again:");
            }

            int[] poleCisel = new int[delkaPole];
            for (int i = 0; i < poleCisel.Length; i++)
            {
                poleCisel[i] = random.Next(0, 1000);
            }

            Console.WriteLine($"here is the array: ");

            for (int i = 0; i < poleCisel.Length; i++)
            {
                Console.Write($"{poleCisel[i]} ");
            }

            int sumMin = poleCisel.Sum() - poleCisel.Max();
            int sumMax = poleCisel.Sum() - poleCisel.Min();

            Console.WriteLine($"\nMinimal summary is {sumMin} and maximal summary is {sumMax}.");
            Console.ReadLine();
        }
    }
}