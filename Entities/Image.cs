using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Image
    {
        // PROPERTIES

        [DisplayName("ID de imagen")]
        public int ImageId { get; set; }

        [DisplayName("URL de imagen")]
        public string Url { get; set; }
    }
}
