﻿using Digi21.OpenGis.CoordinateSystems;
using System;
using System.Collections.Generic;

namespace Digi21.OpenGis.CoordinateTransformations.Algorithms
{
    [WktParameter(0, "geoid_model_file", ParameterType.String), OpenGisMathTransform(ClassificationName = "Geographic3DToGravityRelatedHeightEGM"), AuthorityOperation(Authority = "EPSG", AuthorityCode = "9661")]
    public sealed class Geographic3DToGravityRelatedHeightEGM : IMathTransform, IDisposable
    {
        public Geographic3DToGravityRelatedHeightEGM(IProjection parameters) => throw null;
        public Geographic3DToGravityRelatedHeightEGM(string geoidModelFile) => throw null;
        public Geographic3DToGravityRelatedHeightEGM(IProjection parameters, bool inverse) => throw null;
        public Geographic3DToGravityRelatedHeightEGM(string geoidModelFile, bool inverse) => throw null;
        public Array Derivative(double[] point) => throw null;
        public void Dispose() => throw null;
        public IEnumerable<double[]> GetCodomainConvexHull(IEnumerable<double[]> ord) => throw null;
        public DomainFlags GetDomainFlags(IEnumerable<double[]> ord) => throw null;
        public IEnumerable<double[]> Transform(IEnumerable<double[]> points) => throw null;
        public double[] Transform(double[] point) => throw null;

        // Properties
        public IMathTransform Inverse { get; }
        public bool IsIdentity { get; }
        public int TargetDimension { get; }
        public int SourceDimension { get; }
        public string Xml { get; }
        public string Wkt { get; }
    }
}
