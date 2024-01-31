using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        // METHODS

        public override string ToString()
        {
            if (XX != "" && DNI != 0 && Y != "")
                return $"{XX}-{DNI}-{Y}";
            else if (DNI != 0)
                return DNI.ToString();
            else
                return "";
        }
    }
}
