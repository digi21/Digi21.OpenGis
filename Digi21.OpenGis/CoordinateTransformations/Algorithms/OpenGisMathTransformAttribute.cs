using System;

namespace Digi21.OpenGis.CoordinateTransformations.Algorithms
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class OpenGisMathTransformAttribute : Attribute
    {
        public OpenGisMathTransformAttribute() => throw null;
        public OpenGisMathTransformAttribute(string classificationName) => throw null;
        public string ClassificationName { get; set; }
    }
}
