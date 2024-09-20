namespace IntroToCSharp.Common.Exercise1
{
    /// <summary>
    /// Represents an enemy that can modify a game object
    /// </summary>
    public class Enemy : GameObject, IModifyObject
    {
        private readonly int RESPAWN_RATE_MS = 60000; // 1 minute = 60,000ms
        public int respawnAfterMSecs;

        public Enemy(string iD, bool isActive,
            float x, float y, float z)
            : base(iD, isActive, x, y, z)
        {
            this.respawnAfterMSecs = RESPAWN_RATE_MS;
        }

        public Enemy(string iD, bool isActive,
            float x, float y, float z, int respawnAfterMSecs)
            : base(iD, isActive, x, y, z)
        {
            this.respawnAfterMSecs = respawnAfterMSecs;
        }

        public bool Apply(GameObject obj)
        {
            var player = obj as Player;

            if (player == null)
                return false;

            player.health -= 10;
            return true;
        }

        public override string ToString()
        {
            return $"Enemy: {ID} at ({X}, {Y}, {Z}) respawning in {respawnAfterMSecs} millisecs";
        }
    }
}