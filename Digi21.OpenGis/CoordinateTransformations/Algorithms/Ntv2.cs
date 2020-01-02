using Digi21.OpenGis.CoordinateSystems;
using System;
using System.Collections.Generic;

namespace Digi21.OpenGis.CoordinateTransformations.Algorithms
{
    [OpenGisMathTransform(ClassificationName = "ntv2"), WktParameter(0, "Latitude_and_longitude_difference_file", ParameterType.String), AuthorityOperation(Authority = "EPSG", AuthorityCode = "9615")]
    public class Ntv2 : IMathTransform, IDisposable
    {
        public Ntv2(IProjection parameters) => throw null;
        public Ntv2(string latitudeAndLongitudeDifferenceFile) => throw null;
        public Ntv2(IProjection parameters, bool inverse) => throw null;
        public Ntv2(string latitudeAndLongitudeDifferenceFile, bool inverse) => throw null;
        public Array Derivative(double[] point) => throw null;
        public void Dispose() => throw null;
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
