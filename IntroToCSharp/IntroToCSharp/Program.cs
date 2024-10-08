namespace IntroToCSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Group 3A, 2 for Group 3B, or 3 to exit.");

            int choice = 0;

            do
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Choose 1-3");
                }
            } while (choice < 1 || choice > 3);

            switch (choice)
            {
                case 1:
                    GD3A.Launcher.Start("GD3A");
                    break;

                case 2:
                    GD3A.Launcher.Start("GD3B");
                    break;

                case 3:
                    Console.WriteLine("Goodbye!");
                    break;
            }
        }
    }
}