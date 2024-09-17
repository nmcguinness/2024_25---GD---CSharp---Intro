namespace IntroToCSharp.GD3B.Exercises
{
    public class Weapon : GameObject
    {
        public int damage;
        public IApplyDamage applyDamage;

        public Weapon(string iD, bool isActive,
                       Vector3 position, int damage,
                       IApplyDamage applyDamage)
            : base(iD, isActive, position)
        {
            this.damage = damage;
            this.applyDamage = applyDamage;
        }

        public void DoDamage(GameObject obj)
        {
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
            return $"Weapon: {ID} at {position} with {damage} damage";
        }
    }
}