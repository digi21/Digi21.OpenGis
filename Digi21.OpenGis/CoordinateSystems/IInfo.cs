namespace Digi21.OpenGis.CoordinateSystems
{
    public interface IInfo
    {
        // Properties
        string Xml { get; }
        string Wkt { get; }
        string Remarks { get; }
        string Alias { get; }
        string AuthorityCode { get; }
        string Authority { get; }
        string Name { get; }
    }
}
