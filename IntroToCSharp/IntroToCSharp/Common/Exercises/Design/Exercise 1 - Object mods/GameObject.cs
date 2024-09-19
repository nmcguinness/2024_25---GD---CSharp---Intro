namespace IntroToCSharp.Common.Exercise1
{
    /// <summary>
    /// Represents a base game object within our game
    /// </summary>
    public class GameObject
    {
        #region Fields

        private string id;
        private bool isActive;
        private float x, y, z;

        #endregion Fields

        #region Properties

        /*
     Unary e.g. x++, --x, i++
     Binary e.g. 3 + 2, 45/6, 78%15, 34^2
     Ternary e.g. (boolean expression) ? <true value> : <false value>
           string season = (month == "Jan") ? "Winter" : "Not Winter";
     */

        /// <summary>
        /// ID property for GameObject
        /// </summary>
        /// <example>
        /// GameObject o1 = new GameObject();
        /// o1.ID = "some amazing game object";
        /// Console.WriteLine(o1.ID);
        /// string yourID = o1.ID;
        /// </example>
        public string ID
        {
            get => id;
            set => id = (value == null || value.Length == 0)
                ? "Default ID" : value; //Ternary operator
        }

        public bool IsActive { get => isActive; set => isActive = value; }
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float Z { get => z; set => z = value; }

        #endregion Properties

        #region Constructors

        public GameObject() : this("Default", false, 0, 0, 0)
        {
        }

        public GameObject(string iD, bool isActive,
            float x, float y, float z)
        {
            id = iD;
            this.isActive = isActive;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion Constructors

        #region Methods - Housekeeping

        public override string ToString()
        {
            return $"GameObject: {id} at ({x}, {y}, {z})";
        }

        #endregion Methods - Housekeeping
    }
}