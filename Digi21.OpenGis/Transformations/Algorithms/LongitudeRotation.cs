using Digi21.OpenGis.CoordinateSystems;
using System;
using System.Collections.Generic;

namespace Digi21.OpenGis.Transformations.Algorithms
{
    [OpenGisMathTransform(ClassificationName = "longitude_rotation"), AuthorityOperation(Authority = "EPSG", AuthorityCode = "9601"), WktParameter(0, "rotation", ParameterType.Angular)]
    public sealed class LongitudeRotation : IMathTransform
    {
        public LongitudeRotation(IProjection parameters) => throw null;
        public LongitudeRotation(IProjection parameters, bool inverse) => throw null;
        public LongitudeRotation(int dim, double rotation, bool inverse) => throw null;
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
