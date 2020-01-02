namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class CompoundCoordinateSystem : CoordinateSystem
    {
        // Methods
        public CompoundCoordinateSystem(string name, CoordinateSystem head, CoordinateSystem tail) => throw null;
        public CompoundCoordinateSystem(string name, string authority, string authorityCode, string alias, string info, CoordinateSystem head, CoordinateSystem tail) => throw null;
        public sealed override object Clone() => throw null;
        public sealed override AxisInfo GetAxis(int dimension) => throw null;
        public sealed override IUnit GetUnits(int dimension) => throw null;

        // Properties
        public sealed override string Xml { get; }
        public sealed override string Wkt { get; }
        public sealed override int Dimension { get; }
        public sealed override string Name { get; }
        public CoordinateSystem TailCS { get; }
        public CoordinateSystem HeadCS { get; }
    }
}
