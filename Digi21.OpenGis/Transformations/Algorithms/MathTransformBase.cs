using System;
using System.Collections.Generic;

namespace Digi21.OpenGis.Transformations.Algorithms
{
    public abstract class MathTransformBase : IMathTransform
    {
        public virtual Array Derivative(double[] point) => throw null;
        public virtual IEnumerable<double[]> GetCodomainConvexHull(IEnumerable<double[]> ord) => throw null;
        public virtual DomainFlags GetDomainFlags(IEnumerable<double[]> ord) => throw null;
        public virtual IEnumerable<double[]> Transform(IEnumerable<double[]> points) => throw null;
        public virtual double[] Transform(double[] point) => throw null;

        // Properties
        public abstract IMathTransform Inverse { get; }
        public virtual bool IsIdentity { get; }
        public virtual int TargetDimension { get; }
        public virtual int SourceDimension { get; }
        public virtual string Xml { get; }
        public virtual string Wkt { get; }
    }
}
