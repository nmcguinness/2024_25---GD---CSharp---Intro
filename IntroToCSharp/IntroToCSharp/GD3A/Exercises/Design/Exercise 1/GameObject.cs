namespace IntroToCSharp.GD3A.Exercises
{
    public class GameObject
    {
        public string ID;
        public bool isActive;
        public float x, y, z;

        public GameObject(string iD, bool isActive,
            float x, float y, float z)
        {
            ID = iD;
            this.isActive = isActive;
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}