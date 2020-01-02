using System;
using System.Collections.Generic;

namespace Digi21.OpenGis.CoordinateTransformations
{
    public interface IMathTransform
    {
        Array Derivative(double[] point);
        IEnumerable<double[]> GetCodomainConvexHull(IEnumerable<double[]> ord);
        DomainFlags GetDomainFlags(IEnumerable<double[]> ord);
        IEnumerable<double[]> Transform(IEnumerable<double[]> points);
        double[] Transform(double[] point);

        IMathTransform Inverse { get; }
        bool IsIdentity { get; }
        int TargetDimension { get; }
        int SourceDimension { get; }
        string Xml { get; }
        string Wkt { get; }
    }
}
