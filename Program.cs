namespace _6zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("no");



            }
            if (num >= 1)
            {
                if (num <= 100)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
               
            }
                if (num < 0)
                {
                   
                    if (num <= -100)
                    {
                        Console.WriteLine("yes");
                    }
                else
                {
                    Console.WriteLine("no");
                }
            }
            
        }
    }
}