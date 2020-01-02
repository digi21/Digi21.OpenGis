using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.CoordinateTransformations
{
    public struct Parameter
    {
        public Parameter(ProjectionParameter parameter) => throw null;
        public Parameter(string name, string value) => throw null;
        public Parameter(string name, double value) => throw null;
        public string Name { get; set; }
        public object Value { get; set; }
    }
}
