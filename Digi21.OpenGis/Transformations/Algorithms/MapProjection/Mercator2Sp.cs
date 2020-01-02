using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.Transformations.Algorithms.MapProjection
{
    [WktParameter(3, "false_northing", ParameterType.Length), AuthorityOperation(Authority = "EPSG", AuthorityCode = "9805"), WktParameter(2, "false_easting", ParameterType.Length), OpenGisMathTransform(ClassificationName = "Mercator_2SP"), WktParameter(0, "standard_parallel_1", ParameterType.Angular), WktParameter(1, "central_meridian", ParameterType.Angular)]
    public sealed class Mercator2Sp : MapProjectionBase
    {
        public Mercator2Sp(IProjection parameters, bool inversa) => throw null;
        public sealed override void Geo2Proj(double λ, double ϕ, out double x, out double y) => throw null;
        public sealed override void Proj2Geo(double x, double y, out double λ, out double ϕ) => throw null;

        public sealed override IMathTransform Inverse { get; }
    }
}
