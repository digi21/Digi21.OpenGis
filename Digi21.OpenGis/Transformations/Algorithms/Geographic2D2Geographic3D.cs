using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.Transformations.Algorithms
{
    [AuthorityOperation(Authority = "EPSG", AuthorityCode = "9659")]
    public class Geographic2D2Geographic3D : Affine
    {
        public Geographic2D2Geographic3D() : base(null, false) => throw null;
        public Geographic2D2Geographic3D(IProjection parameters) : base(null, false) => throw null;
        public Geographic2D2Geographic3D(bool inverse) : base(null, false) => throw null;
        public Geographic2D2Geographic3D(IProjection parameters, bool inverse) : base(null, false) => throw null;

        public override IMathTransform Inverse { get; }
    }
}
