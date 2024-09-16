namespace IntroToCSharp.GD3A.Exercises
{
    public class Player : GameObject
    {
        public int health;

        public Player(string iD, bool isActive,
            float x, float y, float z, int health)
            : base(iD, isActive, x, y, z)
        {
            this.health = health;
        }
    }
}