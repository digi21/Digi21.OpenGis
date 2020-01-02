namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class VerticalCoordinateSystem : CoordinateSystem
    {
        public VerticalCoordinateSystem(string name, string authority, string authorityCode, string alias, string info, ILinearUnit linearUnit, IVerticalDatum verticalDatum, AxisInfo axis1) => throw null;
        public sealed override object Clone() => throw null;

        public sealed override string Xml { get; }
        public sealed override string Wkt { get; }
        public ILinearUnit VerticalUnit { get; }
        public IVerticalDatum VerticalDatum { get; }
    }
}
