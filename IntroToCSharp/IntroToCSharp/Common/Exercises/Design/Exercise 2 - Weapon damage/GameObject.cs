using IntroToCSharp.Common.Utilities;

namespace IntroToCSharp.Common.Exercise2
{
    public class GameObject
    {
        #region Fields

        private string id;
        private bool isActive;
        private Vector3? position; //rotation, scale, etc.

        #endregion Fields

        #region Properties

        public string ID { get => id; set => id = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public Vector3 Position { get => position; set => position = value; }

        #endregion Properties

        #region Constructors

        public GameObject() : this("default go", true,
         new Vector3(0, 0, 0))
        {
        }

        public GameObject(string iD, bool isActive,
            Vector3 position)
        {
            this.ID = iD;
            this.IsActive = isActive;
            this.Position = position;
        }

        #endregion Constructors

        #region Methods - Housekeeping

        public override string ToString()
        {
            // return "GameObject" + this.ID + " at " + this.position;

            return $"GameObject: {ID} at {Position} with isActive {IsActive}";
        }

        #endregion Methods - Housekeeping
    }
}