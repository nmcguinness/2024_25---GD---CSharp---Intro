namespace IntroToCSharp.Common.Exercise1
{
    /// <summary>
    /// Represents a player within our game
    /// </summary>
    public class Player : GameObject
    {
        private static readonly float START_Y_POSITION = 10;

        #region Fields

        public int health;

        #endregion Fields

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value >= PLAYER_HEALTH_MIN && value <= PLAYER_HEALTH_MAX
                    ? value
                    : PLAYER_HEALTH_MIN;
            }
        }

        #region Constructors

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

        #endregion Constructors

        #region Methods - Housekeeping

        public override string ToString()
        {
            return $"Player: {ID} at ({X}, {Y}, {Z}) with {health} health";
        }

        #endregion Methods - Housekeeping
    }
}