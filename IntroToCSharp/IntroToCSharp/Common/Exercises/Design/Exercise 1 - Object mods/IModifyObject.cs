namespace IntroToCSharp.Common.Exercise1
{
    /// <summary>
    /// Any object implementing this interface can modify a game object
    /// </summary>
    /// <see cref="Enemy"/>
    public interface IModifyObject
    {
        public bool Apply(GameObject obj);
    }
}