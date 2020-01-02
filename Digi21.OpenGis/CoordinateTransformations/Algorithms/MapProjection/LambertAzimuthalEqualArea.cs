using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.CoordinateTransformations.Algorithms.MapProjection
{
    [WktParameter(0, "latitude_of_center", ParameterType.Angular), OpenGisMathTransform(ClassificationName = "Lambert_Azimuthal_Equal_Area"), WktParameter(3, "false_northing", ParameterType.Length), WktParameter(1, "longitude_of_center", ParameterType.Angular), AuthorityOperation(Authority = "EPSG", AuthorityCode = "9820"), WktParameter(2, "false_easting", ParameterType.Length)]
    public sealed class LambertAzimuthalEqualArea : MapProjectionBase
    {
        public LambertAzimuthalEqualArea(IProjection parameters, bool inversa) => throw null;
        public sealed override void Geo2Proj(double λ, double ϕ, out double x, out double y) => throw null;
        public sealed override void Proj2Geo(double x, double y, out double λ, out double ϕ) => throw null;

        public sealed override IMathTransform Inverse { get; }
    }
}
