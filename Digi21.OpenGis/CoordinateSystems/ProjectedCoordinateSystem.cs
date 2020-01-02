namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class ProjectedCoordinateSystem : HorizontalCoordinateSystem
    {
        // Methods
        public ProjectedCoordinateSystem(string name, string authority, string authorityCode, string alias, string info, GeographicCoordinateSystem gcs, IProjection projection, ILinearUnit linearUnit, AxisInfo axis0, AxisInfo axis1) => throw null;
        public sealed override object Clone() => throw null;

        // Properties
        public sealed override string Xml { get; }
        public sealed override string Wkt { get; }
        public IProjection Projection { get; }
        public ILinearUnit LinearUnit { get; }
        public GeographicCoordinateSystem GeographicCoordinateSystem { get; }
    }
}
