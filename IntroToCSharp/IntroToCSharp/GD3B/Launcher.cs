﻿using IntroToCSharp.Common.Exercise2;
using IntroToCSharp.Common.Utilities;

/// GD3B specific code should be placed in this namespace.
namespace IntroToCSharp.GD3B
{
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

            Console.WriteLine("\n************************** Selected Exercise Solutions **************************n");
            launcher.StartExercises();
        }

        #region Demos

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

            Console.WriteLine("\n****DemoPredicate****\n");
            DemoPredicate();
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