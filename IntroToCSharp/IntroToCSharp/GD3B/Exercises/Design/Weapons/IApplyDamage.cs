namespace IntroToCSharp.GD3B.Exercises
{
    /// <summary>
    /// Contract where any implementing class implements the methods
    /// </summary>
    public interface IApplyDamage
    {
        bool Apply(GameObject obj);
    }

    public class ApplySpeedDamage : IApplyDamage
    {
        public bool Apply(GameObject obj)
        {
            Player? p = obj as Player;

            if (p == null)
                return false;

            p.moveSpeed *= 0.8f; //0.8f
            return true;
        }
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