using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.CoordinateTransformations.Algorithms.MapProjection
{
    [OpenGisMathTransform(ClassificationName = "Lambert_Conformal_Conic_2SP"), AuthorityOperation(Authority = "EPSG", AuthorityCode = "9802"), WktParameter(1, "central_meridian", ParameterType.Angular), WktParameter(2, "standard_parallel1", ParameterType.Angular), WktParameter(3, "standard_parallel2", ParameterType.Angular), WktParameter(0, "latitude_of_origin", ParameterType.Angular), WktParameter(4, "false_easting", ParameterType.Length), WktParameter(5, "false_northing", ParameterType.Length)]
    public sealed class LambertConformalConic2SP : MapProjectionBase
    {
        public LambertConformalConic2SP(IProjection parameters, bool inversa) => throw null;
        public sealed override void Geo2Proj(double λ, double ϕ, out double x, out double y) => throw null;
        public sealed override void Proj2Geo(double x, double y, out double λ, out double ϕ) => throw null;

        public sealed override IMathTransform Inverse { get; }
    }
}
