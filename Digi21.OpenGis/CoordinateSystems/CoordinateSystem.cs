using Digi21.OpenGis.Positioning;
using System;

namespace Digi21.OpenGis.CoordinateSystems
{
    public abstract class CoordinateSystem : BaseInfo, IDisposable
    {
        public abstract object Clone();
        public void Dispose() => throw null;
        protected virtual void Dispose(bool A_0) => throw null;
        public virtual AxisInfo GetAxis(int dimension) => throw null;
        public virtual IUnit GetUnits(int dimension) => throw null;

        public abstract override string Xml { get; }
        public abstract override string Wkt { get; }
        public Envelope DefaultEnvelope { get; }
        public virtual int Dimension { get; }
    }
}
