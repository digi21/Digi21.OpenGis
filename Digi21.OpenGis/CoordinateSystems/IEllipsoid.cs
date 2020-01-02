using System;

namespace Digi21.OpenGis.CoordinateSystems
{
    public interface IEllipsoid : IInfo, ICloneable
    {
        ILinearUnit LinearUnit { get; }
        bool IvfDefinitive { get; }
        double InverseFlattening { get; }
        double SemiMinorAxis { get; }
        double SemiMajorAxis { get; }
    }
}
