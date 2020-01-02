using System.Collections.Generic;

namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class Projection : IProjection
    {
        // Methods
        public Projection(string className, IEnumerable<ProjectionParameter> parameters) => throw null;
        public object Clone() => throw null;

        // Properties
        // Warning: Properties with arguments are not supported in C#. Getter of a Parameter property was decompiled as a method.
        public ProjectionParameter get_Parameter(string name) => throw null;
        // Warning: Properties with arguments are not supported in C#. Getter of a Parameter property was decompiled as a method.
        public ProjectionParameter get_Parameter(int index) => throw null;
        // Warning: Properties with arguments are not supported in C#. Setter of a Parameter property was decompiled as a method.
        public void set_Parameter(int index, ProjectionParameter value) => throw null;
        public int NumParameters { get; }
        public string ClassName { get; set; }
    }
}
