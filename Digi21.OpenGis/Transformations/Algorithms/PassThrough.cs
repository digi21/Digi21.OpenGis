using System;
using System.Collections.Generic;

namespace Digi21.OpenGis.Transformations.Algorithms
{
    [OpenGisMathTransform(ClassificationName = "Passthrough")]
    public class PassThrough : IMathTransform
    {
        public PassThrough(int firstAffectedOrdinate, IMathTransform mathTransform) => throw null;
        public Array Derivative(double[] point) => throw null;
        public IEnumerable<double[]> GetCodomainConvexHull(IEnumerable<double[]> ord) => throw null;
        public DomainFlags GetDomainFlags(IEnumerable<double[]> ord) => throw null;
        public IEnumerable<double[]> Transform(IEnumerable<double[]> points) => throw null;
        public double[] Transform(double[] point) => throw null;

        public IMathTransform Inverse { get; }
        public bool IsIdentity { get; }
        public int TargetDimension { get; }
        public int SourceDimension { get; }
        public string Xml { get; }
        public string Wkt { get; }
    }
}
