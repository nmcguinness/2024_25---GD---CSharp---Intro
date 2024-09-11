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

        //RFR - NMCG - Make this run within 60-80 FPS
    }
}