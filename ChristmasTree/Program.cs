namespace ChristmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Here i make variables and give them a value
            int spaces = 7;
            int stars = 1;            

            //I make a for loop and use it for how tall the tree is
            for (int i = 0; i < 8; i++)
            {
                //I use this to make every second line green, and make the spaces for The green lines
                if (i%2 == 0)
                {
                    for (int j = 0; j < spaces; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < stars; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                    }
                }
                else
                {
                    //This is used to make spaces for all the green and red lines 
                    for (int j = 0; j < spaces; j++)
                    {
                        Console.Write(" ");
                    }
                    //This is is used to make every second line red and green
                    for (int j = 0; j < stars; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("*");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("*");
                        }
                    }
                }
                
                Console.WriteLine();
                stars += 2;
                spaces--;  
            }
            Console.Read();
        }
    }
}