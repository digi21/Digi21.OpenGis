namespace Digi21.OpenGis.CoordinateSystems
{
    public interface ICoordinateSystemAuthorityFactory
    {
        IAngularUnit CreateAngularUnit(string code);
        CompoundCoordinateSystem CreateCompoundCoordinateSystem(string code);
        IEllipsoid CreateEllipsoid(string code);
        GeocentricCoordinateSystem CreateGeocentricCoordinateSystem(string code);
        GeographicCoordinateSystem CreateGeographicCoordinateSystem(string code);
        HorizontalCoordinateSystem CreateHorizontalCoordinateSystem(string code);
        IHorizontalDatum CreateHorizontalDatum(string code);
        ILinearUnit CreateLinearUnit(string code);
        IPrimeMeridian CreatePrimeMeridian(string code);
        ProjectedCoordinateSystem CreateProjectedCoordinateSystem(string code);
        VerticalCoordinateSystem CreateVerticalCoordinateSystem(string code);
        IVerticalDatum CreateVerticalDatum(string code);
        string DescriptionText(string code);
        string GeoidFromWKTName(string wkt);
        string WktGeoidName(int geoid);

        string Authority { get; }
    }
}
