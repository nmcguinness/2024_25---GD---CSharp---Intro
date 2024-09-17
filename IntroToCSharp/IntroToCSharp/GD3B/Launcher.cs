using IntroToCSharp.GD3B.Exercises;

using IntroToCSharp.GD3B.Exercises;

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
            Launcher launcher = new Launcher();
            launcher.StartDemos();
        }

        public void StartDemos()
        {
            Console.WriteLine("\n****DemoClasses****\n");
            DemoClasses();

            Console.WriteLine("\n****DemoInheritance****\n");
            DemoInheritance();

            Console.WriteLine("\n****DemoInterfaces****\n");
            DemoInterfaces();

            Console.WriteLine("\n****DemoList****\n");
            DemoList();

            Console.WriteLine("\n****DemoListInterfaces****\n");
            DemoListInterfaces();
        }

        private void DemoClasses()
        {
            //  throw new NotImplementedException();
            Vector3 v1 = new Vector3(1, 2, 3);
            Vector3 v2 = new Vector3(10, 20, 30);

            Console.WriteLine(v1);
            Console.WriteLine(v1.Equals(v2));
        }

        private void DemoInheritance()
        {
            GameObject go1 = new GameObject("go1", true, new Vector3(0, 0, 0));
            Console.WriteLine(go1);

            Player p1 = new Player("max", true, new Vector3(0, 10, 0),
                                                            100, 25.5f);
            Console.WriteLine(p1);

            //Weapon w1 = new Weapon("plasma rifle",
            //                    true, new Vector3(10, 10, 0), 10);
            //Console.WriteLine(w1);

            //Console.WriteLine($"Before weapon: {p1}");
            //w1.Apply(p1);
            //Console.WriteLine($"After weapon: {p1}");
        }

        private void DemoInterfaces()
        {
            //IApplyDamage applyDamage = new ApplySpeedDamage(0.5f);
            //Weapon w1 = new Weapon("health killer rifle", true,
            //            new Vector3(10, 10, 0), applyDamage);

            //Player p1 = new Player("max", true, new Vector3(0, 10, 0),
            //                              100, 25.5f);

            //Console.WriteLine(p1);
            //w1.DoDamage(p1);
            //Console.WriteLine(p1);
            //w1.DoDamage(p1);
            //Console.WriteLine(p1);
            //w1.DoDamage(p1);
            //Console.WriteLine(p1);
        }

        private void DemoListInterfaces()
        {
            List<IApplyDamage> damageList = new List<IApplyDamage>
            {
                new ApplyHealthDamage(1),
                new ApplySpeedDamage(0.95f)
            };

            Weapon w1 = new Weapon("health killer rifle", true,
                                       new Vector3(10, 10, 0), damageList);

            Player p1 = new Player("max", true, new Vector3(0, 10, 0), 100, 50);

            Console.WriteLine(p1);
            w1.DoDamage(p1);
            Console.WriteLine(p1);
        }

        private void DemoList()
        {
            //simple demo
            List<string> strList = new List<string>();
            strList.Add("apple"); strList.Add("banana"); strList.Add("kiwi");

            Console.WriteLine(strList[0]);
            Console.WriteLine(strList.Count);

            for (int i = 0; i < strList.Count; i++)
                Console.WriteLine(strList[i]);

            foreach (string s in strList)
                Console.WriteLine(s);

            strList.RemoveAt(1);
            Console.WriteLine(strList.Remove("kiwi"));
            strList.Clear();

            List<int> ageList = new List<int>
            {
                21, 19, 24, 32, 18, 27, 22
            };

            //print in reverse order
            for (int i = ageList.Count - 1; i >= 0; i--)
                Console.WriteLine(ageList[i]);

            //sort
            ageList.Sort();

            foreach (int age in ageList)
                Console.WriteLine(age);

            //class demo
            List<Player> pList = new List<Player>
            {
                new Player("anna", true, new Vector3(0, 10, 0), 100, 5),
                new Player("bob", true, new Vector3(0, 40, 0), 50, 2),
                new Player("ciara", true, new Vector3(0, 60, 0), 25, 1)
            };

            foreach (Player p in pList)
                Console.WriteLine(p);
        }
    }
}

//Console.WriteLine("Hello, World!");
//int x = 6;
//var z = 2 * x;
//Console.WriteLine(z);

//Vector3 v1 = new Vector3(1, 2, 3);
//Console.WriteLine(v1.ToString());
//Console.WriteLine(v1);

//Vector3 v2 = new Vector3(1, 2, 3);
//Console.WriteLine(v1.Equals(v2));

//v2.X = 1000; //change x value using property
//Console.WriteLine(v1.Equals(v2));
//Console.WriteLine(v2.X); //access x value using property

////TODO - NMCG - Override operator ==
//bool areEqual = v1 == v2;
//Console.WriteLine(areEqual);
//Console.WriteLine(v1 == v2);

////BUG - NMCG - Does equals always work?
//var t = 10;