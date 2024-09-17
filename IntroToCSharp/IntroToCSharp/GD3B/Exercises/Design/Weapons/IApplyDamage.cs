namespace IntroToCSharp.GD3B.Exercises
{
    /// <summary>
    /// Contract where any implementing class implements the methods
    /// </summary>
    public interface IApplyDamage
    {
        bool Apply(GameObject obj);
    }

    public class ApplyHealthDamage : IApplyDamage
    {
        public bool Apply(GameObject obj)
        {
            Player? p = obj as Player;

            if (p == null)
                return false;

            p.health -= 10;
            return true;
        }
    }
}