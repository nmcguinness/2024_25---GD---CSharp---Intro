using IntroToCSharp.Common.Exercise2;
using IntroToCSharp.Common.Utilities;
using System.Reflection;

/// GD3B specific code should be placed in this namespace.
namespace IntroToCSharp.GD3B
{
    internal class Character
    {
        public int health;
        public int strength;
        public int rank;

        public Character(int health, int strength, int rank)
        {
            this.health = health;
            this.strength = strength;
            this.rank = rank;
        }

        public override string ToString()
        {
            return $"{health}, {strength}, {rank}";
        }
    }

    internal class Launcher
    {
        /// <summary>
        /// Insertion point for GD3B code.
        /// </summary>
        /// <par4m name="groupName">Group identifier</param>
        public static void Start(string groupName)
        {
            Console.WriteLine($"\n************************** Group: {groupName} **************************\n");
            Launcher launcher = new Launcher();

            Console.WriteLine("\n************************** Demos **************************n");
            launcher.StartDemos();

            //Console.WriteLine("\n************************** Selected Exercise Solutions **************************n");
            //launcher.StartExercises();
        }

        #region Demos

        public void StartDemos()
        {
            //Console.WriteLine("\n****DemoClasses****\n");
            //DemoClasses();

            //Console.WriteLine("\n****DemoInheritance****\n");
            //DemoInheritance();

            //Console.WriteLine("\n****DemoInterfaces****\n");
            //DemoInterfaces();

            //Console.WriteLine("\n****DemoList****\n");
            //DemoList();

            //Console.WriteLine("\n****DemoPredicate****\n");
            //DemoPredicate();

            Console.WriteLine("\n****DemoAction****\n");
            DemoAction();

            Console.WriteLine("\n****DemoFunc****\n");
            DemoFunc();

            Console.WriteLine("\n****DemoFuncStrings****\n");
            DemoFuncStrings();

            //Console.WriteLine("\n****DemoDelegate****\n");
            //DemoDelegate();

            //Console.WriteLine("\n****DemoEvent****\n");
            //DemoEvent();
        }

        private void ShowWinMsg()
        {
            Console.WriteLine("You won!!!!");
        }

        private void PlayBeep()
        {
            Console.Beep(500, 2000);
        }

        private void Send(string IP, string msg)
        {
            Console.WriteLine($"sending {msg} to {IP}");
        }

        private void DemoAction()
        {
            //stores a reference to the ShowWinMsg() code
            Action doResponse = ShowWinMsg;
            //invoke the code the action points to
            doResponse();
            //now re-assign the action and invoke the code
            doResponse = PlayBeep;
            doResponse();

            //stores a ref to a method that accepts parameters
            Action<string, string> notifyAction = Send;
            notifyAction("192.168.1.2", "Disconnect");

            List<Action<string, string>> notifyList
                = new List<Action<string, string>>
                {
                    Send /*
                          * lost of methods with same signature
                          * i.e. void name(string, string)
                          */
                };

            foreach (var notify in notifyList)
                notify("a", "b");
        }

        private float add(int x, int y)
        { return x + y; }

        private float divide(int x, int y)
        { return x / y; }

        private float mod(int x, int y)
        { return x % y; }

        private void DemoFunc()
        {
            Func<int, int, float> arithFunc;

            arithFunc = add;

            Console.WriteLine(arithFunc(13, 10));

            List<Func<int, int, float>> arithFuncs
                    = new List<Func<int, int, float>>
            {
                add, divide, mod
            };

            Random rand = new Random();
            int randFuncIndex = rand.Next(0, 2);

            float result = arithFuncs[randFuncIndex](3, 2);
            Console.WriteLine(result);

            List<Func<Character, int, bool>> upgradeFuncs
                   = new List<Func<Character, int, bool>>
           {
                UpgradeStrength, UpgradeHealth
           };

            Character p = new Character(100, 1000, 5);

            UpgradeHealth(p, 50);
            UpgradeStrength(p, 25);

            foreach (var upgrade in upgradeFuncs)
                upgrade(p, 10);
        }

        private bool UpgradeStrength(Character p, int delta)
        {
            p.strength += delta;
            return true;
        }

        private bool UpgradeHealth(Character p, int delta)
        {
            if (p.rank >= 100)
                p.health += delta * 4;
            else
                p.health += delta * 2;

            return true;
        }

        private void DemoFuncStrings()
        {
            string id = "     rOBERT";

            //apply a list of actions to this string
            // format: remove whitespace, lowercase all, uppercase first char

            //create 3 Actions to perform those format changes

            //store in a list

            //apply to the string

            //test it!
        }

        private void DemoDelegate()
        {
        }

        private void DemoEvent()
        {
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

        #endregion Demos

        #region Exercises

        private void StartExercises()
        {
            Console.WriteLine("\nLists & Predicates - Exercise 2...\n");
            Exercise2();
        }

        private void Exercise2()
        {
            List<Player> playerList = new List<Player>
            {
                new Player("anna", true, new Vector3(0, 10, 0), 100, 5),
                new Player("bob", true, new Vector3(0, 40, 0), 55, 2),
                new Player("ciara", true, new Vector3(0, 60, 0), 25, 1)
            };

            Console.WriteLine("Enter a name to search for: ");
            string? searchName = Console.ReadLine();

            Predicate<Player> idAndHealth = (p) =>
            {
                return p.ID.Equals(searchName) && p.Health >= 20;
            };

            List<Player> searchResult = playerList.FindAll(idAndHealth);
            Console.WriteLine($"Count: {searchResult.Count}");

            Console.WriteLine("Top search result:\n");
            if (searchResult.Count > 0)
                Console.WriteLine(searchResult[0]);
        }

        /// <summary>
        /// This hard-coded predicate is used to filter out the right person
        /// BUT it has a limitation - it is hard-coded to filter out "bob"
        /// INSTEAD we prefer to use a language feature called lambda expressions
        /// SEE Exercise2 for an example of a lambda expression
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private bool IsRightPerson(Player p)
        {
            return p.ID.Equals("bob");
        }

        #endregion Exercises
    }
}