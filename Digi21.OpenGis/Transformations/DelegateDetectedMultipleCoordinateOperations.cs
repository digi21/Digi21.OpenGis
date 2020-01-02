using System.Collections.Generic;

namespace Digi21.OpenGis.Transformations
{
    public delegate string DelegateDetectedMultipleCoordinateOperations(string sourceCrs, string destinationCrs, IEnumerable<CoordinateOperation> locatedOperations);
}
