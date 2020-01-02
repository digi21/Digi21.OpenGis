using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.Transformations.Algorithms.MapProjection
{
    [WktParameter(3, "false_northing", ParameterType.Length), WktParameter(0, "latitude_of_origin", ParameterType.Angular), WktParameter(1, "central_meridian", ParameterType.Angular), WktParameter(2, "false_easting", ParameterType.Length), AuthorityOperation(Authority = "EPSG", AuthorityCode = "9806"), OpenGisMathTransform(ClassificationName = "Cassini_Soldner")]
    public sealed class CassiniSoldner : MapProjectionBase
    {
        public CassiniSoldner(IProjection parameters, bool inversa) => throw null;
        public sealed override void Geo2Proj(double λ, double ϕ, out double x, out double y) => throw null;
        public sealed override void Proj2Geo(double x, double y, out double λ, out double ϕ) => throw null;

        public sealed override IMathTransform Inverse { get; }
    }
}
