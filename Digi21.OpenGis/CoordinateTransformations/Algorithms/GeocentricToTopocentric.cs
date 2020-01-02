using Digi21.OpenGis.CoordinateSystems;
using System;
using System.Collections.Generic;

namespace Digi21.OpenGis.CoordinateTransformations.Algorithms
{
    [OpenGisMathTransform(ClassificationName = "Geographic_To_Topocentric"), OpenGisMathTransform(ClassificationName = "Topocentric_To_Geographic"), WktParameter(3, "geocentric_y_of_topocentric_origin", ParameterType.Length), WktParameter(4, "geocentric_z_of_topocentric_origin", ParameterType.Length), WktParameter(1, "semi_minor", ParameterType.Length), WktParameter(0, "semi_major", ParameterType.Length), AuthorityOperation(Authority = "EPSG", AuthorityCode = "9836"), WktParameter(2, "geocentric_x_of_topocentric_origin", ParameterType.Length)]
    public sealed class GeocentricToTopocentric : IMathTransform
    {
        public GeocentricToTopocentric(IProjection parameters) => throw null;
        public GeocentricToTopocentric(IProjection parameters, bool inverse) => throw null;
        public GeocentricToTopocentric(double semiMajorAxis, double semiMinorAxis, double geocentricXOfTopocentricOrigin, double geocentricYOfTopocentricOrigin, double geocentricZOfTopocentricOrigin, bool inverse) => throw null;
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
