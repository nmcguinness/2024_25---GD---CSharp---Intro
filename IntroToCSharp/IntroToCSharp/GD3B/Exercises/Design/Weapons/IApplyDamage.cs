using System.Numerics;

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
        private float speedModifier;

        public ApplySpeedDamage(float speedModifier)
        {
            this.speedModifier = speedModifier;
        }

        public bool Apply(GameObject obj)
        {
            Player? p = obj as Player;

            if (p == null)
                return false;

            p.MoveSpeed *= speedModifier; //0.8f
            return true;
        }
    }

    public class ApplyHealthDamage : IApplyDamage
    {
        private int healthDamage;

        public ApplyHealthDamage(int healthDamage)
        {
            this.healthDamage = healthDamage;
        }

        public bool Apply(GameObject obj)
        {
            Player? p = obj as Player;

            if (p == null)
                return false;

            p.Health -= healthDamage;
            return true;
        }
    }
}