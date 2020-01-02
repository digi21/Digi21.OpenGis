namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class VerticalDatum : Datum, IVerticalDatum
    {
        public VerticalDatum(string name, string authority, string authorityCode, string alias, string info, int datumType) => throw null;
        public sealed override object Clone() => throw null;
        public int CompareTo(IVerticalDatum obj) => throw null;

        public sealed override string Xml { get; }
        public sealed override string Wkt { get; }
    }
}
