using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.CoordinateTransformations.Algorithms.MapProjection
{
    [WktParameter(3, "standard_parallel2", ParameterType.Angular), AuthorityOperation(Authority = "EPSG", AuthorityCode = "9822"), WktParameter(2, "standard_parallel1", ParameterType.Angular), WktParameter(5, "false_northing", ParameterType.Length), WktParameter(1, "longitude_of_center", ParameterType.Angular), WktParameter(0, "latitude_of_center", ParameterType.Angular), WktParameter(4, "false_easting", ParameterType.Length), OpenGisMathTransform(ClassificationName = "Albers_Conic_Equal_Area")]
    public sealed class AlbersConicEqualArea : MapProjectionBase
    {
        public AlbersConicEqualArea(IProjection parameters, bool inversa) => throw null;
        public override void Geo2Proj(double λ, double ϕ, out double x, out double y) => throw null;
        public override void Proj2Geo(double x, double y, out double λ, out double ϕ) => throw null;

        public sealed override IMathTransform Inverse { get; }
    }
}
