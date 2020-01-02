namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class HorizontalDatum : Datum, IHorizontalDatum
    {
        public HorizontalDatum(string name, string authority, string authorityCode, string _alias, string info, int datumType, IEllipsoid ellipsoid) => throw null;
        public sealed override object Clone() => throw null;
        public int CompareTo(IHorizontalDatum obj) => throw null;

        // Properties
        public sealed override string Xml { get; }
        public sealed override string Wkt { get; }
        public Wgs84ConversionInfo Wgs84Parameters { get; }
        public IEllipsoid Ellipsoid { get; }
    }
}
