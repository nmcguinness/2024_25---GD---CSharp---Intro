namespace IntroToCSharp.GD3A.Exercises
{
    public interface IInteract
    {
        public bool Apply(GameObject obj);
    }

    //public class Pickup : GameObject, IInteract
    //{
    //}

    public class Enemy : GameObject, IInteract
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
            player.y += 100;
            return true;
        }
    }
}
}