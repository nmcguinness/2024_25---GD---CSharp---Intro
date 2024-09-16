namespace IntroToCSharp.GD3B.Exercises
{
    public class GameObject
    {
        public string ID;
        public bool isActive;
        public Vector3 position; //rotation, scale, etc.

        public GameObject() : this("default go", true,
            new Vector3(0, 0, 0))
        {
        }

        public GameObject(string iD, bool isActive,
            Vector3 position)
        {
            ID = iD;
            this.isActive = isActive;
            this.position = position;
        }

        public override string ToString()
        {
            // return "GameObject" + this.ID + " at " + this.position;

            return $"GameObject: {ID} at {position} with isActive {isActive}";
        }
    }
}