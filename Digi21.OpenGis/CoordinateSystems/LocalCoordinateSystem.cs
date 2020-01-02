namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class LocalCoordinateSystem : CoordinateSystem
    {
        public LocalCoordinateSystem(string name, ILocalDatum datum, IUnit linearUnit, AxisInfo[] axis) => throw null;
        public sealed override object Clone() => throw null;

        public sealed override string Xml { get; }
        public sealed override string Wkt { get; }
        public ILocalDatum LocalDatum { get; }
    }
}
