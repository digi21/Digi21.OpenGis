using System;
using System.Runtime.InteropServices;

namespace Digi21.OpenGis.CoordinateSystems
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AxisInfo : IComparable<AxisInfo>
    {
        public AxisInfo(string name, AxisOrientationEnum orientation) => throw null;
        public string Name { get; set; }
        public AxisOrientationEnum Orientation { get; set; }
        public string Wkt { get; }
        public int CompareTo(AxisInfo obj) => throw null;
    }
}
