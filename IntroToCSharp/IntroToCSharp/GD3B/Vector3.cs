using IntroToCSharp.GD3B.Utilities;

namespace IntroToCSharp.GD3B
{
    /// <summary>
    /// Represents a 3D vector.
    /// </summary>
    internal class Vector3
    {
        #region Instance Variables

        private float x, y, z;

        #endregion Instance Variables

        #region Properties

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y { get => y; set => y = value; }
        public float Z { get => z; set => z = value; }

        #endregion Properties

        #region Instance Methods

        public Vector3(float x, float y, float z)
        {
            this.x = x; this.y = y; this.z = z;
        }

        public Vector3()
        {
            x = y = z = 0;
        }

        #endregion Instance Methods

        public override string ToString()
        {
            return x + ", " + y + ", " + z;
        }

        public bool Equals(Vector3 other)
        {
            //0.0001f == 0.00009999999f
            //0.75, 0.74999, 0.74999998, 0.7500001
            //return x == other.x
            //    && y == other.y
            //    && z == other.z;

            MathUtility mu = new MathUtility();
            return mu.AreEqualWithin(this.x, other.x, 0.0001f);
        }

        //public bool AreEqualWithin(float a, float b,
        //    float epsilon) //0.000001f
        //{
        //    return Math.Abs(a - b) < epsilon;
        //}
    }
}