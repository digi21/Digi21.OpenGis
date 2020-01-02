using Digi21.OpenGis.Transformations;

namespace Digi21.OpenGis.Epsg
{
    public sealed class CoordinateTransformationAuthorityFactory : ICoordinateTransformationAuthorityFactory
    {
        public CoordinateTransformationAuthorityFactory() => throw null;
        public static ICoordinateTransformation CreateFromCoordinateSystemsCodes(int sourceCode, int targetCode) => throw null;
        public ICoordinateTransformation CreateFromCoordinateSystemsCodes(string sourceCode, string targetCode) => throw null;
        public static ICoordinateTransformation CreateFromCoordinateSystemsCodes(int sourceCode, int targetCode, DelegateDetectedMultipleCoordinateOperations locatedOperations, DelegateCreateVerticalTransformation createVerticalTransformation) => throw null;
        public ICoordinateTransformation CreateFromCoordinateSystemsCodes(string sourceCode, string targetCode, DelegateDetectedMultipleCoordinateOperations locatedOperations, DelegateCreateVerticalTransformation createVerticalTransformation) => throw null;
        public static ICoordinateTransformation CreateFromTransformationCode(int code) => throw null;
        public ICoordinateTransformation CreateFromTransformationCode(string code) => throw null;

        public string Authority { get; }
    }
}
