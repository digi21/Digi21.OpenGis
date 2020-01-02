using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.CoordinateTransformations.Algorithms.MapProjection
{
    [AuthorityOperation(Authority = "EPSG", AuthorityCode = "9809"), OpenGisMathTransform(ClassificationName = "Oblique_Stereographic"), WktParameter(0, "latitude_of_origin", ParameterType.Angular), WktParameter(1, "central_meridian", ParameterType.Angular), WktParameter(2, "scale_factor", ParameterType.Scalar), WktParameter(4, "false_northing", ParameterType.Length), WktParameter(3, "false_easting", ParameterType.Length)]
    public sealed class ObliqueStereographic : MapProjectionBase
    {
        public ObliqueStereographic(IProjection parameters, bool inverse) => throw null;
        public ObliqueStereographic(double semiMajorAxis, double semiMinorAxis, double latitudeOfOrigin, double centralMeridian, double scaleFactor, double falseEasting, double falseNorthing, bool inverse) => throw null;
        public sealed override void Geo2Proj(double λ, double ϕ, out double x, out double y) => throw null;
        public sealed override void Proj2Geo(double x, double y, out double λ, out double ϕ) => throw null;

        public sealed override IMathTransform Inverse { get; }
    }
}
