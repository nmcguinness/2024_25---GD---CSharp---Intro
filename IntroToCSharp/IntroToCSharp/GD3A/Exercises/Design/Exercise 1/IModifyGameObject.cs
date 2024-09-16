namespace IntroToCSharp.GD3A.Exercises
{
    /// <summary>
    /// Any object implementing this interface can modify a game object
    /// </summary>
    /// <see cref="Enemy"/>
    public interface IModifyGameObject
    {
        public bool Apply(GameObject obj);
    }
}