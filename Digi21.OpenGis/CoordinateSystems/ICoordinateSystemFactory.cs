namespace Digi21.OpenGis.CoordinateSystems
{
    public interface ICoordinateSystemFactory
    {
        CompoundCoordinateSystem CreateCompoundCoordinateSystem(string name, CoordinateSystem head, CoordinateSystem tail);
        IEllipsoid CreateEllipsoid(string name, double semiMajorAxis, double semiMinorAxis, ILinearUnit linearUnit);
        IEllipsoid CreateFlattenedSphere(string name, double semiMajorAxis, double inverseFlattening, ILinearUnit linearUnit);
        CoordinateSystem CreateFromWkt(string wellKnownText);
        GeographicCoordinateSystem CreateGeographicCoordinateSystem(string name, IAngularUnit angularUnit, IHorizontalDatum horizontalDatum, IPrimeMeridian primeMeridian, AxisInfo axis0, AxisInfo axis1);
        IHorizontalDatum CreateHorizontalDatum(string name, int datumType, IEllipsoid ellipsoid, Wgs84ConversionInfo toWGS84);
        LocalCoordinateSystem CreateLocalCoordinateSystem(string name, ILocalDatum datum, IUnit unit, AxisInfo[] arExes);
        ILocalDatum CreateLocalDatum(string name, int datumType);
        IPrimeMeridian CreatePrimeMeridian(string name, IAngularUnit angularUnit, double longitude);
        ProjectedCoordinateSystem CreateProjectedCoordinateSystem(string name, GeographicCoordinateSystem gcs, IProjection projection, ILinearUnit linearUnit, AxisInfo axis0, AxisInfo axis1);
        IVerticalDatum CreateVerticalDatum(string name, int datumType);
    }
}
