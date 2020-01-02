using System;

namespace Digi21.OpenGis.CoordinateSystems
{
    public interface IProjection : ICloneable
    {
        ProjectionParameter get_Parameter(string name);
        ProjectionParameter get_Parameter(int index);
        int NumParameters { get; }
        string ClassName { get; }
    }
}
