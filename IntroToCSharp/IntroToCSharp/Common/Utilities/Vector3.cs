namespace IntroToCSharp.Common.Utilities
{
    /// <summary>
    /// Represents a 3D vector.
    /// </summary>
    public class Vector3
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
            //return x == other.x
            //    && y == other.y
            //    && z == other.z;

            return MathUtility.AreEqualWithin(this.x, other.x)
                && MathUtility.AreEqualWithin(this.y, other.y)
                && MathUtility.AreEqualWithin(this.z, other.z);
        }

        //public bool AreEqualWithin(float a, float b,
        //    float epsilon) //0.000001f
        //{
        //    return Math.Abs(a - b) < epsilon;
        //}
    }
}