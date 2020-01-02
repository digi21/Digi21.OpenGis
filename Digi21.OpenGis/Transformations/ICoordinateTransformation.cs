using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.Transformations
{
    public interface ICoordinateTransformation
    {
        IMathTransform MathTransform { get; }
        CoordinateSystem TargetCS { get; }
        CoordinateSystem SourceCS { get; }
        TransformType TransformType { get; }
        string AreaOfUse { get; }
        string Remarks { get; }
        string AuthorityCode { get; }
        string Authority { get; }
        string Name { get; }
    }


}
