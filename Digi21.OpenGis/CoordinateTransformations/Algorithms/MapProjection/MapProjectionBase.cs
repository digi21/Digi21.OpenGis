namespace Digi21.OpenGis.CoordinateTransformations.Algorithms.MapProjection
{
    public abstract class MapProjectionBase : MathTransformBase
    {
        // Methods
        public abstract void Geo2Proj(double λ, double ϕ, out double x, out double y);
        public abstract void Proj2Geo(double x, double y, out double λ, out double ϕ);
        public override double[] Transform(double[] point) => throw null;
    }
}
