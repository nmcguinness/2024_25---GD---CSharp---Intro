/// GD3A specific code should be placed in this namespace.
namespace IntroToCSharp
{
    namespace GD3A
    {
        internal class Launcher
        {
            /// <summary>
            /// Insertion point for GD3A code.
            /// </summary>
            /// <par4m name="groupName">Group identifier</param>
            public static void Start(string groupName)
            {
                Console.WriteLine("Hello, World!");
                int x = 6;
                var z = 2 * x;
                Console.WriteLine(z);
            }
        }
    }
}