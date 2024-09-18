namespace IntroToCSharp.Common.Exercise1
{
    /// <summary>
    /// Represents a base game object within our game
    /// </summary>
    public class GameObject
    {
        public string ID;
        public bool isActive;
        public float x, y, z;

        public GameObject() : this("Default", false, 0, 0, 0)
        {
        }

        public GameObject(string iD, bool isActive,
            float x, float y, float z)
        {
            ID = iD;
            this.isActive = isActive;
            this.x = x; this.y = y; this.z = z;
        }

        public override string ToString()
        {
            return $"GameObject: {ID} at ({x}, {y}, {z})";
        }
    }
}