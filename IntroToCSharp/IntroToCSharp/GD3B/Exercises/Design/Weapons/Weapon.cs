namespace IntroToCSharp.GD3B.Exercises
{
    /*************************** VERSION 3 ***************************/

    public class Weapon : GameObject
    {
        #region Fields

        private List<IApplyDamage> applyDamageList;

        #endregion Fields

        #region Properties

        public List<IApplyDamage> DamageList
        {
            get
            {
                return this.applyDamageList;
            }
        }

        #endregion Properties

        #region Constructor

        public Weapon(string iD, bool isActive,
                     Vector3 position,
                     List<IApplyDamage> applyDamageList)
          : base(iD, isActive, position)
        {
            this.applyDamageList = applyDamageList;
        }

        #endregion Constructor

        #region Entity Specific

        //TODO - ALL - Add DoRandomDamage method

        public void DoDamage(GameObject obj)
        {
            foreach (IApplyDamage applyDamage in applyDamageList)
                applyDamage.Apply(obj);
        }

        #endregion Entity Specific

        #region General - Housekeeping

        public override string ToString()
        {
            return $"Weapon: {ID} at {Position}";
        }

        #endregion General - Housekeeping
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