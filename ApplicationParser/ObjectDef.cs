using System.Collections.Generic;

namespace ApplicationParser
{
    public class ObjectDef : Artifact
    {
        public IEnumerable<Field> Fields { get; set; }
    }
}