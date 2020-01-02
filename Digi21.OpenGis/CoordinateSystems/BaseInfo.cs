namespace Digi21.OpenGis.CoordinateSystems
{
    public abstract class BaseInfo : IInfo
    {
        public abstract string Xml { get; }
        public abstract string Wkt { get; }
        public string Remarks { get; }
        public string Alias { get; }
        public string AuthorityCode { get; }
        public string Authority { get; }
        public virtual string Name { get; }
    }
}
