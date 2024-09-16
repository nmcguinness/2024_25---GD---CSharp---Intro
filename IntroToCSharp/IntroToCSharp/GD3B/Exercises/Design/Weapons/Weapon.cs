namespace IntroToCSharp.GD3B.Exercises
{
    public class Weapon : GameObject
    {
        public int damage;

        public Weapon(string iD, bool isActive,
                       Vector3 position, int damage)
            : base(iD, isActive, position)
        {
            this.damage = damage;
        }

        public override string ToString()
        {
            return $"Weapon: {ID} at {position} with {damage} damage";
        }
    }
}