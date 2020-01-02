using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.Transformations.Algorithms
{
    [AuthorityOperation(Authority = "EPSG", AuthorityCode = "1032"), WktParameter(6, "scale_difference", ParameterType.Scalar), OpenGisMathTransform(ClassificationName = "coordinate_frame_rotation"), WktParameter(3, "x_axis_rotation", ParameterType.Angular), WktParameter(2, "z_axis_translation", ParameterType.Length), WktParameter(1, "y_axis_translation", ParameterType.Length), WktParameter(0, "x_axis_translation", ParameterType.Length), WktParameter(4, "y_axis_rotation", ParameterType.Angular), WktParameter(5, "z_axis_rotation", ParameterType.Angular)]
    public class CoordinateFrameRotation : Affine
    {
        public CoordinateFrameRotation(IProjection parameters) : base(null, false) => throw null;
        public CoordinateFrameRotation(IProjection parameters, bool inverse) : base(null, false) => throw null;
        public CoordinateFrameRotation(double dx, double dy, double dz, double rX, double rY, double rZ, double dS) : base(null, false) => throw null;
    }
}
