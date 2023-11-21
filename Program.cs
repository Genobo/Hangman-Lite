namespace Hangman_Lite
{
    internal class Program
    {
        static void DrawStage(int stage)
        {
            if (stage == 0)
            {
                Console.WriteLine("  +---+ ");
                Console.WriteLine("  |   | ");
                Console.WriteLine("      | ");
                Console.WriteLine("      | ");
                Console.WriteLine("      | ");
                Console.WriteLine("      | ");
                Console.WriteLine("=========");
            }
            else if (stage == 1)
            {
                Console.WriteLine("  +---+ ");
                Console.WriteLine("  |   | ");
                Console.WriteLine("  0   | ");
                Console.WriteLine("      | ");
                Console.WriteLine("      | ");
                Console.WriteLine("      | ");
                Console.WriteLine("=========");
            }
            else if (stage == 2)
            {
                Console.WriteLine("  +---+ ");
                Console.WriteLine("  |   | ");
                Console.WriteLine("  0   | ");
                Console.WriteLine(" /|\\  | ");
                Console.WriteLine("      | ");
                Console.WriteLine("      | ");
                Console.WriteLine("=========");
            }
            else
            {
                Console.WriteLine("  +---+ ");
                Console.WriteLine("  |   | ");
                Console.WriteLine("  0   | ");
                Console.WriteLine(" /|\\  | ");
                Console.WriteLine(" / \\  | ");
                Console.WriteLine("      | ");
                Console.WriteLine("=========");
            }
        }


        static void Main(string[] args)
        {
            Random generator = new Random();
            int subject;
            int draw = 0;
            subject = generator.Next(1, 9);
            string guess;
            string word = "COMPUTER";
            string displayWord = "________";
            int tempLength = word.Length;
            bool done = false;
            
            while (!done)
            {
                DrawStage(draw);
                Console.WriteLine(displayWord);
                Console.WriteLine($"You have guessed wrong {draw} times.  Guess a letter:");
                guess = Console.ReadLine().ToUpper();

           
                    
                if (word.Contains(guess))
                {
                    for (int i = 0; i < tempLength; i++)
                    {
                        if (word[i] == guess[0])
                        {
                            displayWord = displayWord.Remove(i, 1);
                            displayWord = displayWord.Insert(i, guess);
                        }
                    }
                }
                else
                {
                    draw += 1;

                }
                      
                
               
            }
        }
    }
}