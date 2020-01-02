using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.Epsg
{
    public sealed class CoordinateSystemAuthorityFactory : ICoordinateSystemAuthorityFactory
    {
        static CoordinateSystemAuthorityFactory() => throw null;
        public CoordinateSystemAuthorityFactory() => throw null;
        public static IAngularUnit CreateAngularUnit(int code) => throw null;
        public IAngularUnit CreateAngularUnit(string code) => throw null;
        public static CompoundCoordinateSystem CreateCompoundCoordinateSystem(int code) => throw null;
        public CompoundCoordinateSystem CreateCompoundCoordinateSystem(string code) => throw null;
        public static CompoundCoordinateSystem CreateCompoundCoordinateSystem(int horizontal, int vertical) => throw null;
        public static CoordinateSystem CreateCoordinateSystem(int code) => throw null;
        public static IEllipsoid CreateEllipsoid(int code) => throw null;
        public IEllipsoid CreateEllipsoid(string code) => throw null;
        public static GeocentricCoordinateSystem CreateGeocentricCoordinateSystem(int code) => throw null;
        public GeocentricCoordinateSystem CreateGeocentricCoordinateSystem(string code) => throw null;
        public static GeographicCoordinateSystem CreateGeographicCoordinateSystem(int code) => throw null;
        public GeographicCoordinateSystem CreateGeographicCoordinateSystem(string code) => throw null;
        public static GeographicCoordinateSystem CreateGeographicCoordinateSystem(int code, AxisInfo[] axis) => throw null;
        public static HorizontalCoordinateSystem CreateHorizontalCoordinateSystem(int code) => throw null;
        public HorizontalCoordinateSystem CreateHorizontalCoordinateSystem(string code) => throw null;
        public static IHorizontalDatum CreateHorizontalDatum(int code) => throw null;
        public IHorizontalDatum CreateHorizontalDatum(string code) => throw null;
        public static ILinearUnit CreateLinearUnit(int code) => throw null;
        public ILinearUnit CreateLinearUnit(string code) => throw null;
        public static IPrimeMeridian CreatePrimeMeridian(int code) => throw null;
        public IPrimeMeridian CreatePrimeMeridian(string code) => throw null;
        public static ProjectedCoordinateSystem CreateProjectedCoordinateSystem(int code) => throw null;
        public ProjectedCoordinateSystem CreateProjectedCoordinateSystem(string code) => throw null;
        public static ProjectedCoordinateSystem CreateProjectedCoordinateSystem(int projectionCode, int geographicCrsCode) => throw null;
        public static ProjectedCoordinateSystem CreateProjectedCoordinateSystem(int code, AxisInfo[] ejes) => throw null;
        public static IUnit CreateUnit(int code) => throw null;
        public static VerticalCoordinateSystem CreateVerticalCoordinateSystem(int code) => throw null;
        public VerticalCoordinateSystem CreateVerticalCoordinateSystem(string code) => throw null;
        public static IVerticalDatum CreateVerticalDatum(int code) => throw null;
        public IVerticalDatum CreateVerticalDatum(string code) => throw null;
        public static string DescriptionText(int code) => throw null;
        public string DescriptionText(string code) => throw null;
        public static int DialogSelectCoordinateSystem() => throw null;
        public static int DialogSelectVerticalCoordinateSystem() => throw null;
        public static GeographicCoordinateSystem FabricaSistemaGeografico2DAsociadoConSistemaGeografico3D(int code, AxisInfo ejeX, AxisInfo ejeY) => throw null;
        public string GeoidFromWKTName(string wkt) => throw null;
        public static GeographicCoordinateSystem LocalizaSistemaGeográfico3D(int code, AxisInfo ejeX, AxisInfo ejeY) => throw null;
        public string WktGeoidName(int geoid) => throw null;

        public string Authority { get; }
    }
}
