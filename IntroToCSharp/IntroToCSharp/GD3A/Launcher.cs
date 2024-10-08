using IntroToCSharp.Common.Exercise1;
using System.Reflection.Metadata.Ecma335;

/// GD3A specific code should be placed in this namespace.
namespace IntroToCSharp.GD3A
{
    internal class Pickup
    {
        public string id;
        public int value;
        public bool isConsumed;

        public Pickup(string id, int value, bool isConsumed)
        {
            this.id = id;
            this.value = value;
            this.isConsumed = isConsumed;
        }

        public override string ToString()
        {
            return $"{id}, {value}, {isConsumed}";
        }
    }

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

            //Console.WriteLine("\n************************** Selected Exercise Solutions **************************n");
            //launcher.StartExercises();
        }

        #region Demos

        public void StartDemos()
        {
            //Console.WriteLine("\n**** DemoConsole ****\n");
            //DemoConsole();

            //Console.WriteLine("\n**** DemoInheritance ****\n");
            //DemoInheritance();

            //Console.WriteLine("\n**** DemoInterface ****\n");
            //DemoInterface();

            //Console.WriteLine("\n****DemoList****\n");
            //DemoList();

            //Console.WriteLine("\n****DemoPredicate****\n");
            //DemoPredicate();

            //Console.WriteLine("\n****DemoAction****\n");
            //DemoAction();

            Console.WriteLine("\n****DemoFunc****\n");
            DemoFunc();

            Console.WriteLine("\n****DemoFuncStrings****\n");
            DemoFuncStrings();

            //Console.WriteLine("\n****DemoDelegate****\n");
            //DemoDelegate();

            //Console.WriteLine("\n****DemoEvent****\n");
            //DemoEvent();
        }

        #region Demo - Action

        private void DemoAction()
        {
            Action notifyEvent = RingBell;
            NotifyMe(notifyEvent, "Event 1");
            NotifyMe(NotifyMessage, "Event 2");
        }

        private void NotifyMe(Action action, string msg)
        {
            Console.WriteLine(msg); action();
        }

        private void RingBell()
        {
            Console.Beep(2000, 1500);
        }

        private void NotifyMessage()
        {
            Console.WriteLine("Something occured...");
        }

        #endregion Demo - Action

        private void DemoFunc()
        {
            //create a Pickup
            var p1 = new Pickup("potion of eternal sarcasm", 1000, false);

            //create 2-3 functions that do something to a pickup
            Func<Pickup, bool> doValueReset = ResetValueIf;
            Func<Pickup, bool> doIDReset = (p) =>
            {
                if (p.id == string.Empty)
                    p.id = "Default";
                return true;
            };
            Func<Pickup, bool> doConsumedResetIfValue = (p) =>
            {
                if (p.value < 0) p.isConsumed = true;
                return true;
            };
            List<Func<Pickup, bool>> pickupFuncList = new List<Func<Pickup, bool>>
            {
                doValueReset, doIDReset, doConsumedResetIfValue
            };

            foreach (var pickupFunc in pickupFuncList)
                pickupFunc(p1);

            Console.WriteLine(p1);
        }

        private bool ResetValueIf(Pickup p)
        {
            if (p.value < 0 || p.value > 1000)
                p.value = 100;
            return true;
        }

        private void DemoFuncStrings()
        {
            //create string to represent your first name
            string fName = "     bob";   //Bob

            //write 2-3 lambda expressions to process that string in some way
            Func<string, string> removeSpace = (str) => str.Trim();
            Func<string, string> uppercase = (str) => str.ToUpper();

            //store those string processors in a sortedlist
            List<Func<string, string>> strProcessors
                = new List<Func<string, string>> {
                removeSpace, uppercase
            };

            string processedStr = fName;
            //apply to the string
            foreach (var processor in strProcessors)
            {
                processedStr = processor(processedStr);
            }

            Console.WriteLine($"After processing: {processedStr}");

            //list a strings and apply the processors to the list of strings
        }

        private void DemoDelegate()
        {
            throw new NotImplementedException();
        }

        private void DemoEvent()
        {
            throw new NotImplementedException();
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
            List<string> strList = new List<string>
            {
                "apple", "banana", "kiwi"
            };

            //    strList.Add("apple"); strList.Add("banana"); strList.Add("kiwi");

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
            Console.WriteLine("Enter skill threshold: ");
            string skillThreshold = Console.ReadLine();
            int skillInt = int.Parse(skillThreshold);

            //lambda expression: (input-parameters) => expression
            Predicate<int> skillsPred = (value) => value > skillInt;
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

            //TODO - All - Create list of players and a predicate to filter out active players
            List<Player> pList = new List<Player>
            {
                new Player("alpha", true, 3,4,5),
                new Player("beta", false, 6,7,8),
                new Player("chi", true, 9,10,11),
                new Player("phi", false, 12,13,14)
            };

            Console.WriteLine("Active players...");

            Predicate<Player> isActivePred = (p) => p.IsActive;
            List<Player> activePlayers = pList.FindAll(isActivePred);
            foreach (Player p in activePlayers)
                Console.WriteLine(p);

            Console.WriteLine("Active players with 'a'...");

            Predicate<Player> IsActiveWithLetter = (player) =>
            {
                //code...
                return player.IsActive && player.ID.IndexOf('a') == 0;
            };

            List<Player> activeWithPlayers = pList.FindAll(IsActiveWithLetter);
            foreach (Player p in activeWithPlayers)
                Console.WriteLine(p);

            List<int> numList = new List<int>
            {
                1,3,52,3,2,15,7,48,2,201
            };

            Predicate<int> myPred = (number) => number % 2 == 1;
            int count = CountAll(numList, myPred);
            Console.WriteLine($"Odd: {count}");
        }

        /// <summary>
        /// Count if the number matches any 1 of the predicates in the list
        /// </summary>
        /// <param name="numList"></param>
        /// <param name="predList"></param>
        /// <returns></returns>
        private int CountIfMatchAny(List<int> numList, List<Predicate<int>> predList)
        {
            return -1;
        }

        private int CountAll(List<int> numList, Predicate<int> pred)
        {
            int count = 0;
            for (int i = 0; i < numList.Count; i++)
            {
                if (pred(numList[i]))
                    count++;
            }
            return count;
        }

        private bool IsHighlySkilled(int skill)
        {
            return skill > 200;
        }

        #endregion Demos

        #region Exercises

        private void StartExercises()
        {
            //Exercise2();
        }

        #endregion Exercises
    }
}