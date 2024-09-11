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

            Vector3 v1 = new Vector3(1, 2, 3);
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v1);

            Vector3 v2 = new Vector3(1, 2, 3);
            Console.WriteLine(v1.Equals(v2));

            v2.X = 1000; //change x value using property
            Console.WriteLine(v1.Equals(v2));
            Console.WriteLine(v2.X); //access x value using property

            //TODO - NMCG - Override operator ==
            bool areEqual = v1 == v2;
            Console.WriteLine(areEqual);
            Console.WriteLine(v1 == v2);

            //BUG - NMCG - Does equals always work?
            var t = 10;
        }
    }
}