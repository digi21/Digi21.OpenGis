namespace Digi21.OpenGis.CoordinateTransformations
{
    public struct CoordinateOperation
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
        public int? Variant { get; set; }
        public string Scope { get; set; }
        public float? Accuracy { get; set; }
        public int MethodCode { get; set; }
        public string Remarks { get; set; }
        public string InformationSource { get; set; }
        public CoordinateOperation(string code, string name, string type, string version, int? variant, string scope, float? accuracy, int methodCode, string remarks, string informationSource) => throw null;
    }
}
