using Digi21.OpenGis.CoordinateSystems;
using System;
using System.Collections.Generic;

namespace Digi21.OpenGis.CoordinateTransformations.Algorithms
{
    [AuthorityOperation(Authority = "EPSG", AuthorityCode = "9613"), WktParameter(0, "latitude_difference_file", ParameterType.String), WktParameter(1, "longitude_difference_file", ParameterType.String), OpenGisMathTransform(ClassificationName = "nadcon")]
    public sealed class NadCon : IMathTransform, IDisposable
    {
        public NadCon(IProjection parameters) => throw null;
        public NadCon(IProjection parameters, bool inverse) => throw null;
        public NadCon(string latitudeDifferenceFile, string longitudeDifferenceFile) => throw null;
        public NadCon(string latitudeDifferenceFile, string longitudeDifferenceFile, bool inverse) => throw null;
        public Array Derivative(double[] point) => throw null;
        public void Dispose() => throw null;
        public IEnumerable<double[]> GetCodomainConvexHull(IEnumerable<double[]> ord) => throw null;
        public DomainFlags GetDomainFlags(IEnumerable<double[]> ord) => throw null;
        public IEnumerable<double[]> Transform(IEnumerable<double[]> points) => throw null;
        public double[] Transform(double[] point) => throw null;

        // Properties
        public IMathTransform Inverse { get; }
        public bool IsIdentity { get; }
        public int TargetDimension { get; }
        public int SourceDimension { get; }
        public string Xml { get; }
        public string Wkt { get; }
    }
}
