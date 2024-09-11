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
    }
}