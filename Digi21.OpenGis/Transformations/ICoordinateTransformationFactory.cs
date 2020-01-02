using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.Transformations
{
    public interface ICoordinateTransformationFactory
    {
        ICoordinateTransformation CreateFromCoordinateSystems(CoordinateSystem sourceCS, CoordinateSystem targetCS);
    }
}
