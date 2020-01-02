using System;

namespace Digi21.OpenGis.CoordinateSystems
{
    public interface IDatum : IInfo, ICloneable
    {
        // Properties
        int DatumType { get; }
    }
}
