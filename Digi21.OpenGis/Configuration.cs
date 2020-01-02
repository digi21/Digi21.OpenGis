namespace Digi21.OpenGis
{
    public static class Configuration
    {
        static Configuration() { throw null; }

        // Properties
        public static WktCompatibilityType WktCompatibility { get; set; }
        public static bool CreateHorizontalWktIfVerticalSystemIsLocal { get; set; }
    }
}
