namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class LinearUnit : BaseInfo, ILinearUnit
    {
        public LinearUnit(string name, double metersPerUnit) => throw null;
        public LinearUnit(string name, string authority, string authorityCode, string alias, string info, double metersPerUnit) => throw null;
        public object Clone() => throw null;

        public sealed override string Xml { get; }
        public sealed override string Wkt { get; }
        public double MetersPerUnit { get; }
    }
}
