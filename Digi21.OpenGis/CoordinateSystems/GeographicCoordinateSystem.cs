namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class GeographicCoordinateSystem : HorizontalCoordinateSystem
    {
        public GeographicCoordinateSystem(string name, string authority, string authorityCode, string alias, string info, IAngularUnit angularUnit, IHorizontalDatum horizontalDatum, IPrimeMeridian primeMeridian, AxisInfo[] ejes, IUnit[] unidades) => throw null;
        public sealed override object Clone() => throw null;
        public int CompareTo(GeographicCoordinateSystem obj) => throw null;
        public Wgs84ConversionInfo GetWGS84ConversionInfo(int index) => throw null;

        // Properties
        public sealed override string Xml { get; }
        public sealed override string Wkt { get; }
        public int NumConversionToWGS84 { get; }
        public IPrimeMeridian PrimeMeridian { get; }
        public IAngularUnit AngularUnit { get; }
    }
}
