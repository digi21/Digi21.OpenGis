namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class GeocentricCoordinateSystem : CoordinateSystem
    {
        // Methods
        public GeocentricCoordinateSystem(string name, string authority, string authorityCode, string alias, string info, ILinearUnit linearUnit, IHorizontalDatum horizontalDatum, IPrimeMeridian primeMeridian, AxisInfo axis1, AxisInfo axis2, AxisInfo axis3) => throw null;
        public sealed override object Clone() => throw null;

        // Properties
        public sealed override string Xml { get; }
        public sealed override string Wkt { get; }
        public IPrimeMeridian PrimeMeridian { get; }
        public ILinearUnit LinearUnit { get; }
        public IHorizontalDatum HorizontalDatum { get; }
    }
}
