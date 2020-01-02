using System;

namespace Digi21.OpenGis.CoordinateSystems
{
    public interface IPrimeMeridian : IInfo, ICloneable
    {
        IAngularUnit AngularUnit { get; }
        double Longitude { get; }
    }
}
