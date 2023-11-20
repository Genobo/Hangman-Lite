namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "COMPUTER";
            
            Console.WriteLine("  +---+ ");
            Console.WriteLine("  |   | ");
            Console.WriteLine("      | ");
            Console.WriteLine("      | ");
            Console.WriteLine("      | ");
            Console.WriteLine("      | ");
            Console.WriteLine("=========");
        }

        public static void Hangman1()
        {
            Console.WriteLine("  +---+ ");
            Console.WriteLine("  |   | ");
            Console.WriteLine("  0   | ");
            Console.WriteLine("      | ");
            Console.WriteLine("      | ");
            Console.WriteLine("      | ");
            Console.WriteLine("=========");
        }

        public static void Hangman2()
        {
            Console.WriteLine("  +---+ ");
            Console.WriteLine("  |   | ");
            Console.WriteLine("  0   | ");
            Console.WriteLine(" /|\\ | ");
            Console.WriteLine("      | ");
            Console.WriteLine("      | ");
            Console.WriteLine("=========");
        }

        public static void Hangman3()
        {
            Console.WriteLine("  +---+ ");
            Console.WriteLine("  |   | ");
            Console.WriteLine("  0   | ");
            Console.WriteLine(" /|\\ | ");
            Console.WriteLine(" / \\ | ");
            Console.WriteLine("      | ");
            Console.WriteLine("=========");
        }
    }
}