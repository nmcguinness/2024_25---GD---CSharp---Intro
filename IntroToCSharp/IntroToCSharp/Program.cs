namespace IntroToCSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool bGroupA = false;

            // Start the program for each group - disable the group you are not working in
            if (bGroupA)
                GD3A.Launcher.Start("GD3A");
            else
                GD3B.Launcher.Start("GD3B");
        }
    }
}