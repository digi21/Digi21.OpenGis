using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.CoordinateTransformations.Algorithms
{
    [WktParameter(1, "y_axis_translation", ParameterType.Length), WktParameter(0, "x_axis_translation", ParameterType.Length), WktParameter(2, "z_axis_translation", ParameterType.Length), OpenGisMathTransform(ClassificationName = "geocentric_translations"), AuthorityOperation(Authority = "EPSG", AuthorityCode = "1031")]
    public class GeocentricTranslations : Affine
    {
        // Methods
        public GeocentricTranslations(IProjection parameters) : base(null, false) => throw null;
        public GeocentricTranslations(IProjection parameters, bool inverse) : base(null, false) => throw null;
        public GeocentricTranslations(double dx, double dy, double dz) : base(null, false) => throw null;
    }
}
