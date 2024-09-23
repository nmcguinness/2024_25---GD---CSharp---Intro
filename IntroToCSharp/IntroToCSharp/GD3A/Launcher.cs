using IntroToCSharp.Common.Exercise1;

/// GD3A specific code should be placed in this namespace.
namespace IntroToCSharp.GD3A
{
    internal class Launcher
    {
        /// <summary>
        /// Insertion point for GD3A code.
        /// </summary>
        /// <par4m name="groupName">Group identifier</param>
        public static void Start(string groupName)
        {
            Console.WriteLine($"\n************************** Group: {groupName} **************************\n");
            Launcher launcher = new Launcher();

            Console.WriteLine("\n************************** Demos **************************n");
            launcher.StartDemos();

            Console.WriteLine("\n************************** Selected Exercise Solutions **************************n");
            launcher.StartExercises();
        }

        #region Demos

        public void StartDemos()
        {
            Console.WriteLine("\n**** DemoConsole ****\n");
            DemoConsole();

            Console.WriteLine("\n**** DemoInheritance ****\n");
            DemoInheritance();

            Console.WriteLine("\n**** DemoInterface ****\n");
            DemoInterface();

            Console.WriteLine("\n****DemoList****\n");
            DemoList();

            Console.WriteLine("\n****DemoPredicate****\n");
            DemoPredicate();
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
                new Player("anna", true, 0, 10, 0, 100),
                new Player("bob", true, 0, 40, 0, 50),
                new Player("ciara", true, 0, 60, 0, 25)
            };

            foreach (Player p in pList)
                Console.WriteLine(p);
        }

        private void DemoPredicate()
        {
            List<int> skillsList = new List<int>
                {
                    150, 22, 45, 65, 220, 85
                };

            Console.WriteLine("Highly skilled students predicate as using method...");
            List<int> list1 = skillsList.FindAll(IsHighlySkilled);
            foreach (int skill in list1)
                Console.WriteLine(skill);

            Console.WriteLine("Highly skilled students using predicate as lambda expression...");
            int skillThreshold = 200;
            Predicate<int> skillsPred = (value) => value > skillThreshold;
            List<int> list2 = skillsList.FindAll(skillsPred);
            foreach (int skill in list2)
                Console.WriteLine(skill);

            Console.WriteLine("Nationalities using predicate as lambda expression...");
            List<string> nationalities = new List<string>
                {
                    "IE", "UK", "US", "FR", "DE", "ES", "IE", "UK", "IE"
                };

            Predicate<string> natPred = (nationality) => nationality == "IE";
            List<string> list3 = nationalities.FindAll(natPred);
            Console.WriteLine($"There are {list3.Count} IE students");

            //TODO - All - Create a list of players and predicate to filter out health > 50
        }

        private bool IsHighlySkilled(int skill)
        {
            return skill > 100;
        }

        #endregion Demos

        private void StartExercises()
        {
        }
    }
}