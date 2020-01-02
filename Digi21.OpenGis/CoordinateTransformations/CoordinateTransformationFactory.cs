using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.CoordinateTransformations
{
    public sealed class CoordinateTransformationFactory : ICoordinateTransformationFactory
    {
        public CoordinateTransformationFactory() => throw null;
        public ICoordinateTransformation CreateFrom3DCoordinateSystems(CoordinateSystem sourceCS, CoordinateSystem targetCS, DelegateDetectedMultipleCoordinateOperations locatedOperations, DelegateCreateVerticalTransformation createVerticalTransformation) => throw null;
        public ICoordinateTransformation CreateFromCoordinateSystems(CoordinateSystem sourceCS, CoordinateSystem targetCS) => throw null;
        public ICoordinateTransformation CreateFromCoordinateSystems(CoordinateSystem sourceCS, CoordinateSystem targetCS, DelegateDetectedMultipleCoordinateOperations locatedOperations, DelegateCreateVerticalTransformation createVerticalTransformation) => throw null;
        public static ICoordinateTransformation CreateFromHorizontalCoordinateSystems(CoordinateSystem geográfico3D, CoordinateSystem target, DelegateDetectedMultipleCoordinateOperations locatedOperations) => throw null;
        public ICoordinateTransformation CreateFromVerticalCoordinateSystems(CoordinateSystem sourceCS, CoordinateSystem targetCS, DelegateDetectedMultipleCoordinateOperations locatedOperations, DelegateCreateVerticalTransformation createVerticalTransformation) => throw null;
        public ICoordinateTransformation CreateFromVerticalCoordinateSystems(GeographicCoordinateSystem source, VerticalCoordinateSystem target, DelegateDetectedMultipleCoordinateOperations locatedOperations, DelegateCreateVerticalTransformation createVerticalTransformation) => throw null;
        public ICoordinateTransformation CreateFromVerticalCoordinateSystems(VerticalCoordinateSystem source, VerticalCoordinateSystem target, DelegateDetectedMultipleCoordinateOperations locatedOperations, DelegateCreateVerticalTransformation createVerticalTransformation) => throw null;
    }
}
