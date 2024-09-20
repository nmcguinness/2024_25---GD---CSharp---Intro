using IntroToCSharp.Common.Utilities;

namespace IntroToCSharp.Common.Data
{
    /// <summary>
    /// Central storage for game constants.
    /// </summary>
    /// <see cref="IntroToCSharp.Common.Exercise2.Player"/>
    /// <seealso cref="IntroToCSharp.Common.Exercise2.Weapon"/>"/>
    public static class GameConstants
    {
        public static readonly Vector3 PLAYER_START_POSITION = new Vector3(0, 0, 0);
        public static readonly int PLAYER_START_HEALTH = 100;
        public static readonly float PLAYER_START_MOVE_SPEED = 10;
        public static readonly float PLAYER_MAX_MOVE_SPEED = 20;

        public static readonly float START_Y_POSITION = 10;
        public static readonly int PLAYER_HEALTH_MIN = 0;
        public static readonly int PLAYER_HEALTH_MAX = 100;
    }
}