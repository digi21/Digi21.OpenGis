namespace Digi21.OpenGis.CoordinateTransformations
{
    public interface ICoordinateTransformationAuthorityFactory
    {
        ICoordinateTransformation CreateFromCoordinateSystemsCodes(string sourceCode, string targetCode);
        ICoordinateTransformation CreateFromTransformationCode(string code);

        string Authority { get; }
    }
}
