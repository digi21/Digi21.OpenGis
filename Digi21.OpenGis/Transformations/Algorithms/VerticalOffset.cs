using Digi21.OpenGis.CoordinateSystems;
using System;
using System.Collections.Generic;

namespace Digi21.OpenGis.Transformations.Algorithms
{
    [AuthorityOperation(Authority = "EPSG", AuthorityCode = "9616"), WktParameter(0, "vertical_offset", ParameterType.Length), OpenGisMathTransform(ClassificationName = "vertical_offset")]
    public sealed class VerticalOffset : IMathTransform
    {
        public VerticalOffset(IProjection parameters) => throw null;
        public VerticalOffset(double verticalOffset) => throw null;
        public VerticalOffset(IProjection parameters, bool inverse) => throw null;
        public VerticalOffset(double verticalOffset, bool inverse) => throw null;
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
