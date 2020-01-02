namespace Digi21.OpenGis.CoordinateSystems
{
    public sealed class Ellipsoid : BaseInfo, IEllipsoid
    {
        public object Clone() => throw null;
        public static Ellipsoid CreateFromSemiMajorAxisInverseFlattening(string name, string authority, string code, double semiMajorAxis, double inverseFlattening, ILinearUnit linearUnit) => throw null;
        public static Ellipsoid CreateFromSemiMajorAxisSemiMinorAxis(string name, string authority, string code, double semiMajorAxis, double semiMinorAxis, ILinearUnit linearUnit) => throw null;
        public double GetRadiusOfConformalSphere(double ϕ) => throw null;
        public double GetRadiusOfCurvatureInTheMeridian(double ϕ) => throw null;
        public double GetRadiusOfCurvatureInThePrimeVertical(double ϕ) => throw null;

        // Properties
        public sealed override string Xml { get; }
        public sealed override string Wkt { get; }
        public double RadiusOfAuthalicSphere { get; }
        public double SecondEccentricity { get; }
        public double Eccentricity { get; }
        public double Flattening { get; }
        public ILinearUnit LinearUnit { get; }
        public bool IvfDefinitive { get; }
        public double InverseFlattening { get; }
        public double SemiMinorAxis { get; }
        public double SemiMajorAxis { get; }
    }
}
