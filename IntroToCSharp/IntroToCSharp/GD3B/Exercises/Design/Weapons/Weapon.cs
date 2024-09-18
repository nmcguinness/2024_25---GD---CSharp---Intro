namespace IntroToCSharp.GD3B.Exercises
{
    /*************************** VERSION 3 ***************************/

    public class Weapon : GameObject
    {
        // public IApplyDamage applyDamage;
        private List<IApplyDamage> applyDamageList;

        public Weapon(string iD, bool isActive,
                       Vector3 position,
                       List<IApplyDamage> applyDamageList)
            : base(iD, isActive, position)
        {
            this.applyDamageList = applyDamageList;
        }

        //TODO - ALL - Add DoRandomDamage method

        public void DoDamage(GameObject obj)
        {
            foreach (IApplyDamage applyDamage in applyDamageList)
                applyDamage.Apply(obj);
        }

        //public bool Apply(GameObject obj)
        //{
        //    Player? p = obj as Player;

        //    if (p == null)
        //        return false;
        //    else
        //        p.health -= damage;

        //    return true;
        //}

        public override string ToString()
        {
            return $"Weapon: {ID1} at {Position}";
        }
    }

    /*************************** VERSION 2 ***************************/

    /*
         public class Weapon : GameObject
    {
        public IApplyDamage applyDamage;

        public Weapon(string iD, bool isActive,
                       Vector3 position,
                       IApplyDamage applyDamage)
            : base(iD, isActive, position)
        {
            this.applyDamage = applyDamage;
        }

        public void DoDamage(GameObject obj)
        {
            applyDamage.Apply(obj);
        }

        public override string ToString()
        {
            return $"Weapon: {ID} at {position}";
        }
    }

     */

    /*************************** VERSION 1 ***************************/

    /*
         public class Weapon : GameObject
    {
        public int damage;

        public Weapon(string iD, bool isActive,
                       Vector3 position,int damage)
            : base(iD, isActive, position)
        {
            this.damage = damage;
        }

        public bool Apply(GameObject obj)
        {
            Player? p = obj as Player;

            if (p == null)
                return false;
            else
                p.health -= damage;

            return true;
        }

        public override string ToString()
        {
            return $"Weapon: {ID} at {position}";
        }
    }
     */
}