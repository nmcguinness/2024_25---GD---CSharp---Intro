using System.Runtime.CompilerServices;

/// GD3B specific code should be placed in this namespace.
namespace IntroToCSharp.GD3B
{
    internal class Launcher
    {
        //shared by all instances of Launcher
        public static string ID;

        /// <summary>
        /// Insertion point for GD3A code.
        /// </summary>
        /// <par4m name="groupName">Group identifier</param>
        public static void Start(string ID = "GD")
        {
            Console.WriteLine("Hello, World!");
            int x = 6;
            var z = 2 * x;
            Console.WriteLine(z);
        }
    }
}