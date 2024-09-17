using static System.Net.Mime.MediaTypeNames;

namespace IntroToCSharp.GD3B.Exercises
{
    public class Player : GameObject
    {
        public int health;
        public float moveSpeed;

        public Player(string iD, bool isActive,
                       Vector3 position, int health,
                       float moveSpeed)
            : base(iD, isActive, position)
        {
            this.health = health;
            this.moveSpeed = moveSpeed;
        }

        public override string ToString()
        {
            return $"Player: {ID} at {position} with {health} health" +
                $" and {moveSpeed} move speed";
        }
    }
}