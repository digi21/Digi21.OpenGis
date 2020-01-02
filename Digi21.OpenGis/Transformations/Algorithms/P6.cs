using Digi21.OpenGis.CoordinateSystems;

namespace Digi21.OpenGis.Transformations.Algorithms
{
    [WktParameter(2, "bin_grid_origin_easting", ParameterType.Length), WktParameter(1, "bin_grid_origin_j", ParameterType.Length), AuthorityOperation(Authority = "EPSG", AuthorityCode = "9666"), WktParameter(7, "map_grid_bearing_of_bin_grid_j_axis", ParameterType.Angular), WktParameter(8, "bin_node_increment_on_i_axis", ParameterType.Length), WktParameter(9, "bin_node_increment_on_j_axis", ParameterType.Length), OpenGisMathTransform(ClassificationName = "p6"), WktParameter(5, "bin_width_of_i_axis", ParameterType.Length), WktParameter(4, "scale_factor", ParameterType.Scalar), WktParameter(6, "bin_width_of_j_axis", ParameterType.Length), WktParameter(3, "bin_grid_origin_northing", ParameterType.Length), WktParameter(0, "bin_grid_origin_i", ParameterType.Length)]
    public class P6 : MathTransformBase
    {
        public P6(IProjection parameters) => throw null;
        public P6(IProjection parameters, bool inverse) => throw null;
        public sealed override double[] Transform(double[] point) => throw null;

        public sealed override IMathTransform Inverse { get; }
    }
}
