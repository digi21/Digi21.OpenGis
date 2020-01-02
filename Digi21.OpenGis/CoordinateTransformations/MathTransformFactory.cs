using System.Collections.Generic;

namespace Digi21.OpenGis.CoordinateTransformations
{
    public sealed class MathTransformFactory : IMathTransformFactory
    {
        public MathTransformFactory() => throw null;
        public IMathTransform CreateAffineTransform(double[,] matrix) => throw null;
        public IMathTransform CreateConcatenatedTransform(IEnumerable<IMathTransform> transformations) => throw null;
        public IMathTransform CreateConcatenatedTransform(IMathTransform transform1, IMathTransform transform2) => throw null;
        public IMathTransform CreateFromWkt(string wkt) => throw null;
        public IMathTransform CreateFromXml(string xml) => throw null;
        public IMathTransform CreateParameterizedTransform(string classification, IEnumerable<Parameter> parameters) => throw null;
        public IMathTransform CreatePassThroughTransform(int firstAffectedOrdinate, IMathTransform mathTransform) => throw null;

        public bool get_IsParameterLinear(string A_0) => throw null;
        public bool get_IsParameterAngular(string A_0) => throw null;
    }
}
