namespace Digi21.OpenGis.CoordinateSystems
{
    public abstract class Datum : BaseInfo, IDatum
    {
        public abstract object Clone();
        public int DatumType { get; }
    }
}
