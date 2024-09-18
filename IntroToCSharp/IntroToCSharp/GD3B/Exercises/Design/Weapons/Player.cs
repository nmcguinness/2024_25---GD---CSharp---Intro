using IntroToCSharp.GD3B.Data;

namespace IntroToCSharp.GD3B.Exercises
{
    public class Player : GameObject
    {
        public int health;
        public float moveSpeed;

        public Player(string iD)
           : this(iD, true, GameConstants.PLAYER_START_POSITION,
                 GameConstants.PLAYER_START_HEALTH,
                 GameConstants.PLAYER_START_MOVE_SPEED)
        {
        }

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
            return $"Player: {ID1} at {Position} with {health} health" +
                $" and {moveSpeed} move speed";
        }
    }
}