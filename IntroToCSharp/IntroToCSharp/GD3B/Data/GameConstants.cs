namespace IntroToCSharp.GD3B.Data
{
    /// <summary>
    /// Central storage for game constants.
    /// </summary>
    /// <see cref="IntroToCSharp.GD3B.Exercises.Player"/>
    /// <seealso cref="IntroToCSharp.GD3B.Exercises.Weapon"/>"/>
    public static class GameConstants
    {
        public static readonly Vector3 PLAYER_START_POSITION = new Vector3(0, 0, 0);
        public static readonly int PLAYER_START_HEALTH = 100;
        public static readonly float PLAYER_START_MOVE_SPEED = 10;
        public static readonly float PLAYER_MAX_MOVE_SPEED = 20;
    }
}