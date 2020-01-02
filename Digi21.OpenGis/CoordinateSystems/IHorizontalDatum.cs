using System;

namespace Digi21.OpenGis.CoordinateSystems
{
    public interface IHorizontalDatum : IDatum, IComparable<IHorizontalDatum>
    {
        // Properties
        Wgs84ConversionInfo Wgs84Parameters { get; }
        IEllipsoid Ellipsoid { get; }
    }
}
