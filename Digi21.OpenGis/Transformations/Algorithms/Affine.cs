using Digi21.OpenGis.CoordinateSystems;
using System;
using System.Collections.Generic;

namespace Digi21.OpenGis.Transformations.Algorithms
{
    [OpenGisMathTransform(ClassificationName = "Affine")]
    public class Affine : IMathTransform
    {
        public Affine(IProjection parameters, bool inversa) => throw null;
        public static Affine BurwaWolf(double dX, double dY, double dZ, double Rx, double Ry, double Rz, double dS) => throw null;
        public static Affine CoordinateFrameRotation(double dX, double dY, double dZ, double Rx, double Ry, double Rz, double dS) => throw null;
        public static IProjection CreaParámetrosBurwaWolf(double dX, double dY, double dZ, double Rx, double Ry, double Rz, double dS) => throw null;
        public static IProjection CreaParámetrosCoordinateFrameRotation(double dX, double dY, double dZ, double Rx, double Ry, double Rz, double dS) => throw null;
        public static IProjection CreaParámetrosDesplazamientoXYZ(double dx, double dy, double dz) => throw null;
        public static IProjection CreaParámetrosTransformaciónAfín2CoordenadasA3Coordenadas() => throw null;
        public static IProjection CreaParámetrosTransformaciónAfín3CoordenadasA2Coordenadas() => throw null;
        public virtual Array Derivative(double[] point) => throw null;
        public virtual IEnumerable<double[]> GetCodomainConvexHull(IEnumerable<double[]> ord) => throw null;
        public virtual DomainFlags GetDomainFlags(IEnumerable<double[]> ord) => throw null;
        public virtual IEnumerable<double[]> Transform(IEnumerable<double[]> points) => throw null;
        public virtual double[] Transform(double[] point) => throw null;
        public static Affine TransformaciónAfín2CoordenadasA3Coordenadas() => throw null;
        public static Affine TransformaciónAfín2CoordenadasA3CoordenadasIntercambiandoEjes() => throw null;
        public static Affine TransformaciónAfín3CoordenadasA2Coordenadas() => throw null;
        public static Affine TransformaciónAfín3CoordenadasA2CoordenadasIntercambiandoEjes() => throw null;
        public static Affine TransformaciónAfínDiagonalPrincipal(double valor, uint componentes) => throw null;
        public static Affine TransformaciónAfínIntercambiaEjes(uint componentes) => throw null;
        public static Affine TransformaciónNoHacerNada() => throw null;
        public static Affine TransformaciónXYZaXYXYZ() => throw null;
        public static Affine TransformaciónXYZaYXZ() => throw null;
        public static Affine TransformaciónXYZaZXY() => throw null;
        public static Affine TransformaciónZXYaXYZ() => throw null;

        public virtual IMathTransform Inverse { get; }
        public virtual bool IsIdentity { get; }
        public virtual int TargetDimension { get; }
        public virtual int SourceDimension { get; }
        public virtual string Xml { get; }
        public virtual string Wkt { get; }
    }
}
