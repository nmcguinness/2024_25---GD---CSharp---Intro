using IntroToCSharp.GD3A.Utilities;

namespace IntroToCSharp.GD3A
{
    internal class Weapon
    {
        #region Instance Variables

        public bool IsEquipped;
        public string name;
        public float damage;
        public int ammoCount;

        #endregion Instance Variables

        #region Constructors

        public Weapon()  //default constructor
        {
            this.ammoCount = 10;
            this.damage = 100;
            this.name = "Default Weapon";
            this.IsEquipped = false;
        }

        public Weapon(string name, float damage,
            int ammoCount, bool IsEquipped) //full constructor
        {
            this.name = name;
            this.damage = damage;
            this.ammoCount = ammoCount;
            this.IsEquipped = IsEquipped;
        }

        #endregion Constructors

        //TODO - NMCG - Add ToString, Equals, Properties
        public override string ToString()
        {
            //string interpolation example
            return $"Weapon: {name},{damage},{ammoCount},{IsEquipped}";
        }

        public bool Equals(Weapon other)
        {
            return MathUtility.AreEqualWithin(this.damage,
                other.damage, MathUtility.FLOAT_TOLERANCE);

            //MathUtility mathUtility = new MathUtility();
            //return mathUtility.AreEqualWithin(this.damage, other.damage,
            //    0.0001f);
            //return this.damage == other.damage;
        }

        /// <summary>
        /// Compares two floats within a given epsilon.
        /// </summary>
        /// <param name="a">Float a</param>
        /// <param name="b">Float b</param>
        /// <param name="epsilon">Tolerance value</param>
        /// <returns>True if less than epsilon</returns>
        //public bool AreEqualWithin(float a, float b,
        //    float epsilon)
        //{
        //    return Math.Abs(a - b) < epsilon;
        //}

        //RFR - NMCG - Make this run within 60-80 FPS
    }
}