namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class PrimeMeridian : BaseInfo, IPrimeMeridian
    {
        public PrimeMeridian(string nombre, string authority, string authorityCode, string alias, string info, IAngularUnit angularUnit, double longitude) => throw null;
        public object Clone() => throw null;

        // Properties
        public sealed override string Xml { get; }
        public sealed override string Wkt { get; }
        public IAngularUnit AngularUnit { get; }
        public double Longitude { get; }
    }
}
