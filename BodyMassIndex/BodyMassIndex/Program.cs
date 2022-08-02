namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            
            double index;

            Console.WriteLine("Enter your weight: ");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height: ");
            double boy = Convert.ToDouble(Console.ReadLine());

            index = kilo / (boy * boy);

            if (index <= 18)
            {
                Console.WriteLine("WEAK: You are below the ideal weight...");
            }
            else if (index > 18 && index <= 25)
            {
                Console.WriteLine("NORMAL: You are in the ideal weight range...");
            }
            else
            {
                Console.WriteLine("OBEZ: You are above your ideal weight...");
            }

            Console.ReadLine();

        }
    }
}