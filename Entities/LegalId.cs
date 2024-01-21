using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class LegalId
    {
        // PROPERTIES

        public string XX { get; set; }
        public int DNI { get; set; }
        public string Y { get; set; }

        // CONSTRUCT

        public LegalId()
        {
            XX = "XX";
            DNI = 0;
            Y = "Y";
        }

        // METHODS

        public override string ToString()
        {
            return $"{XX}-{DNI}-{Y}";
        }
    }
}
