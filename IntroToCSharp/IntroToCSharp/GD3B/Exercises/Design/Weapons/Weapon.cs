namespace IntroToCSharp.GD3B.Exercises
{
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
            return $"Weapon: {ID} at {position}";
        }
    }
}