using System;

namespace Digi21.OpenGis.Transformations.Algorithms
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class AuthorityOperation : Attribute
    {
        public AuthorityOperation() => throw null;
        public AuthorityOperation(string authority, string authorityCode) => throw null;

        public string AuthorityCode { get; set; }
        public string Authority { get; set; }
    }
}
