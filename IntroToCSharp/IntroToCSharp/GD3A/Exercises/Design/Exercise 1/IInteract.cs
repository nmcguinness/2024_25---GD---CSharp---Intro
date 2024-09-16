namespace IntroToCSharp.GD3A.Exercises
{
    public interface IInteract
    {
        public bool Apply(GameObject obj);
    }

    public class Enemy : GameObject, IInteract
    {
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
}