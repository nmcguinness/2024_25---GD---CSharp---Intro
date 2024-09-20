using IntroToCSharp.Common.Data;

namespace IntroToCSharp.Common.Exercise1
{
    /// <summary>
    /// Represents a player within our game
    /// </summary>
    public class Player : GameObject
    {
        #region Fields

        public int health;

        #endregion Fields

        #region Properties

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value >= GameConstants.PLAYER_HEALTH_MIN
                    && value <= GameConstants.PLAYER_HEALTH_MAX
                    ? value
                    : GameConstants.PLAYER_HEALTH_MIN;
            }
        }

        #endregion Properties

        #region Constructors

        public Player(string iD)
      : base(iD, true, 0, GameConstants.START_Y_POSITION, 0)
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

        #endregion Constructors

        #region Methods - Housekeeping

        public override string ToString()
        {
            return $"Player: {ID} at ({X}, {Y}, {Z}) with {health} health";
        }

        #endregion Methods - Housekeeping
    }
}