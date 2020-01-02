namespace Digi21.OpenGis.CoordinateSystems
{
    public struct ProjectionParameter
    {
        public ProjectionParameter(string name, string value) => throw null;
        public ProjectionParameter(string name, double value) => throw null;
        public string Name { get; set; }
        public object Value { get; set; }
        public string Wkt { get; }
    }
}
