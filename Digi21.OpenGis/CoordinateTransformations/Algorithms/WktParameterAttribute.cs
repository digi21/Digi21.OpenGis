using System;

namespace Digi21.OpenGis.CoordinateTransformations.Algorithms
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class WktParameterAttribute : Attribute
    {
        public WktParameterAttribute() => throw null;
        public WktParameterAttribute(int order, string name, ParameterType parameterType) => throw null;

        public ParameterType ParameterType { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
