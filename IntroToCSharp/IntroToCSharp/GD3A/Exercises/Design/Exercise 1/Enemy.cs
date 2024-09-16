namespace IntroToCSharp.GD3A.Exercises
{
    public class Enemy : GameObject, IModifyGameObject
    {
        public Enemy(string iD, bool isActive,
            float x, float y, float z, int health)
            : base(iD, isActive, x, y, z)
        {
        }

        public bool Apply(GameObject obj)
        {
            var player = obj as Player;

            if (player == null)
                return false;

            player.health -= 10;
            return true;
        }
    }
}