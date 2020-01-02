using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.Transformations.Algorithms.MapProjection
{
    [WktParameter(6, "false_northing", ParameterType.Length), WktParameter(0, "latitude_of_center", ParameterType.Angular), OpenGisMathTransform(ClassificationName = "oblique_mercator"), WktParameter(2, "azimuth", ParameterType.Angular), WktParameter(4, "scale_factor", ParameterType.Scalar), WktParameter(1, "longitude_of_center", ParameterType.Angular), WktParameter(3, "rectified_grid_angle", ParameterType.Angular), WktParameter(5, "false_easting", ParameterType.Length), AuthorityOperation(Authority = "EPSG", AuthorityCode = "9815")]
    public sealed class ObliqueMercator : MapProjectionBase
    {
        public ObliqueMercator(IProjection parameters, bool inversa) => throw null;
        public sealed override void Geo2Proj(double λ, double ϕ, out double x, out double y) => throw null;
        public sealed override void Proj2Geo(double x, double y, out double λ, out double ϕ) => throw null;

        public sealed override IMathTransform Inverse { get; }
    }
}
