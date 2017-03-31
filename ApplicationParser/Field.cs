using System.Collections.Generic;

namespace ApplicationParser
{
    public class Field : Artifact
    {
        public IEnumerable<Artifact> Choices { get; set; }
    }
}
