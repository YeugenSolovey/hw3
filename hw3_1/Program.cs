//task 1.2
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                string msg = "You enter a number: ";
                Console.WriteLine("Enter integer number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(msg + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}