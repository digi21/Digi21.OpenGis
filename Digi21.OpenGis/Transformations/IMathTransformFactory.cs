using System.Collections.Generic;

namespace Digi21.OpenGis.Transformations
{
    public interface IMathTransformFactory
    {
        IMathTransform CreateAffineTransform(double[,] matrix);
        IMathTransform CreateConcatenatedTransform(IMathTransform transform1, IMathTransform transform2);
        IMathTransform CreateFromWkt(string wkt);
        IMathTransform CreateFromXml(string xml);
        IMathTransform CreateParameterizedTransform(string classification, IEnumerable<Parameter> parameters);
        IMathTransform CreatePassThroughTransform(int firstAffectedOrdinate, IMathTransform subTransform);

        bool get_IsParameterLinear(string A_0);
        // Warning: Properties with arguments are not supported in C#. Getter of a IsParameterAngular property was decompiled as a method.
        bool get_IsParameterAngular(string A_0);
    }
}
