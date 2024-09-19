namespace IntroToCSharp.Common.Exercise1
{
    /// <summary>
    /// Represents a player within our game
    /// </summary>
    public class Player : GameObject
    {
        private static readonly float START_Y_POSITION = 10;
        public int health;

        public Player(string iD)
         : base(iD, true, 0, START_Y_POSITION, 0)
        {
            this.health = 100;
        }

        public Player(string iD, bool isActive,
           float x, float y, float z)
           : base(iD, isActive, x, y, z)
        {
            this.health = 100;
        }

        public Player(string iD, bool isActive,
            float x, float y, float z, int health)
            : base(iD, isActive, x, y, z)
        {
            this.health = health;
        }

        public override string ToString()
        {
            return $"Player: {id} at ({x}, {y}, {z}) with {health} health";
        }
    }
}