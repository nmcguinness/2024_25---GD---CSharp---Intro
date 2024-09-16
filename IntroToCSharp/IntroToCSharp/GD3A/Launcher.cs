using IntroToCSharp.GD3A.Exercises;

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
                Launcher launcher = new Launcher();
                launcher.StartDemos();
            }

            public void StartDemos()
            {
                Console.WriteLine("\n**** DemoConsole ****\n");
                DemoConsole();

                Console.WriteLine("\n**** DemoInheritance ****\n");
                DemoInheritance();

                Console.WriteLine("\n**** DemoInterface ****\n");
                DemoInterface();
            }

            private void DemoConsole()
            {
                Console.WriteLine("Hello, World!");
                int x = 6;
                var z = 2 * x;
                Console.WriteLine(z);
            }

            private void DemoInheritance()
            {
                GameObject go1 = new GameObject("go1", true, 0, 0, 0);
                Console.WriteLine(go1);

                Player p1 = new Player("max", true, 0, 10, 0, 100);
                Console.WriteLine(p1);
            }

            private void DemoInterface()
            {
                Player p1 = new Player("max", true, 0, 10, 0, 100);

                Enemy e1 = new Enemy("paladin", true, 10, 10, 0, 1000);

                Console.WriteLine($"Before mod: {p1}");

                //Lets apply the modification made by the enemy to the player
                e1.Apply(p1);

                Console.WriteLine($"After mod: {p1}");
            }
        }
    }
}