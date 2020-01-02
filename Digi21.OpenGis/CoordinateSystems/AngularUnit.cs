namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class AngularUnit : BaseInfo, IAngularUnit
    {
        public AngularUnit(string name, double radiansPerUnit) => throw null;
        public AngularUnit(string name, string authority, string authorityCode, string alias, string info, double radiansPerUnit) => throw null;
        public object Clone() => throw null;

        // Properties
        public sealed override string Xml { get; }
        public sealed override string Wkt { get; }
        public double RadiansPerUnit { get; }
    }
}
