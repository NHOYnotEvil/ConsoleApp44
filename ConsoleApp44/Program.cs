namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number;
            int numberStartExample = 0;
            int stepInExample = 3;
            int stepInExample2 = 5;

            number = rand.Next(0, 101);

            Console.WriteLine("Ваше число:" + number);

            Console.WriteLine("Сумма кратных числу " + stepInExample + ":");
            for (int i = numberStartExample; i <= number; i += stepInExample) 
            { 
                Console.WriteLine(i);
            }

            Console.WriteLine("Сумма кратных числу " + stepInExample2 + ":");
            for (int j = numberStartExample; j <= number; j += stepInExample2)
            {
                Console.WriteLine(j);
            }
        }
    }
}