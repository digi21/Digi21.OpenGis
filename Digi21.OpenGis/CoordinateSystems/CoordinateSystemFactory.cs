namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class CoordinateSystemFactory : ICoordinateSystemFactory
    {
        public CoordinateSystemFactory() => throw null;
        public CompoundCoordinateSystem CreateCompoundCoordinateSystem(string name, CoordinateSystem head, CoordinateSystem tail) => throw null;
        public IEllipsoid CreateEllipsoid(string name, double semiMajorAxis, double semiMinorAxis, ILinearUnit linearUnit) => throw null;
        public IEllipsoid CreateFlattenedSphere(string name, double semiMajorAxis, double inverseFlattening, ILinearUnit linearUnit) => throw null;
        public CoordinateSystem CreateFromWkt(string wellKnownText) => throw null;
        public GeographicCoordinateSystem CreateGeographicCoordinateSystem(string name, IAngularUnit angularUnit, IHorizontalDatum horizontalDatum, IPrimeMeridian primeMeridian, AxisInfo axis0, AxisInfo axis1) => throw null;
        public IHorizontalDatum CreateHorizontalDatum(string name, int datumType, IEllipsoid ellipsoid, Wgs84ConversionInfo toWGS84) => throw null;
        public LocalCoordinateSystem CreateLocalCoordinateSystem(string name, ILocalDatum datum, IUnit unit, AxisInfo[] arExes) => throw null;
        public ILocalDatum CreateLocalDatum(string name, int datumType) => throw null;
        public IPrimeMeridian CreatePrimeMeridian(string name, IAngularUnit angularUnit, double longitude) => throw null;
        public ProjectedCoordinateSystem CreateProjectedCoordinateSystem(string name, GeographicCoordinateSystem gcs, IProjection projection, ILinearUnit linearUnit, AxisInfo axis0, AxisInfo axis1) => throw null;
        public IVerticalDatum CreateVerticalDatum(string name, int datumType) => throw null;
    }
}
