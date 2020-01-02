using Digi21.OpenGis.CoordinateSystems;
using System;
using System.Collections.Generic;

namespace Digi21.OpenGis.Transformations.Algorithms
{
    [AuthorityOperation(Authority = "EPSG", AuthorityCode = "9602"), OpenGisMathTransform(ClassificationName = "Geocentric_To_Ellipsoid"), OpenGisMathTransform(ClassificationName = "Ellipsoid_To_Geocentric")]
    public sealed class GeographicToGeocentric : IMathTransform
    {
        public GeographicToGeocentric(IProjection parameters) => throw null;
        public GeographicToGeocentric(IProjection parameters, bool inverse) => throw null;
        public GeographicToGeocentric(double semiMajorAxis, double semiMinorAxis, bool inverse) => throw null;
        private void CalculaConstantes() => throw null;
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
