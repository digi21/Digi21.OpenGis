using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.CoordinateTransformations.Algorithms.MapProjection
{
    [OpenGisMathTransform(ClassificationName = "Transverse_Mercator_South_Orientated"), WktParameter(4, "false_northing", ParameterType.Length), WktParameter(1, "central_meridian", ParameterType.Angular), WktParameter(2, "scale_factor", ParameterType.Scalar), WktParameter(0, "latitude_of_origin", ParameterType.Angular), WktParameter(3, "false_easting", ParameterType.Length), AuthorityOperation(Authority = "EPSG", AuthorityCode = "9808")]
    public sealed class TransverseMercatorSouthOrientated : MapProjectionBase
    {
        public TransverseMercatorSouthOrientated(IProjection parameters, bool inversa) => throw null;
        public sealed override void Geo2Proj(double λ, double ϕ, out double x, out double y) => throw null;
        public sealed override void Proj2Geo(double x, double y, out double λ, out double ϕ) => throw null;

        public sealed override IMathTransform Inverse { get; }
    }
}
