using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class LegalId
    {
        public LegalId()
        {
            XX = "XX";
            DNI = 0;
            Y = "Y";
        }

        public string XX { get; set; }
        public int DNI { get; set; }
        public string Y { get; set; }

        public override string ToString()
        {
            return $"{XX}-{DNI}-{Y}";
        }
    }
}
