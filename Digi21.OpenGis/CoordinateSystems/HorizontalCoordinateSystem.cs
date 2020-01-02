namespace Digi21.OpenGis.CoordinateSystems
{
    public abstract class HorizontalCoordinateSystem : CoordinateSystem
    {
        public abstract override string Xml { get; }
        public abstract override string Wkt { get; }
        public IHorizontalDatum HorizontalDatum { get; }
    }
}
