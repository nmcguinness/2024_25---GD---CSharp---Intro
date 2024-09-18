using IntroToCSharp.Common.Data;
using IntroToCSharp.Common.Utilities;

namespace IntroToCSharp.Common.Exercise2
{
    public class Player : GameObject
    {
        #region Fields

        private int health;
        private float moveSpeed;

        #endregion Fields

        #region Properties

        public int Health
        {
            get => health;
            set => health = (value >= 0) ? value : 0;
        }

        public float MoveSpeed
        {
            get => moveSpeed;
            set => moveSpeed = value <=
                GameConstants.PLAYER_MAX_MOVE_SPEED ?
                value :
                GameConstants.PLAYER_MAX_MOVE_SPEED;
        }

        #endregion Properties

        #region Constructors

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
            this.Health = health;
            this.MoveSpeed = moveSpeed;
        }

        #endregion Constructors

        #region General - Housekeeping

        public override string ToString()
        {
            return $"Player: {ID} at {Position} with {Health} health" +
                $" and {MoveSpeed} move speed";
        }

        #endregion General - Housekeeping
    }
}