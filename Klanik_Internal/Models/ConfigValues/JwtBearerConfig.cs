using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Models.ConfigValues
{
    public class JwtBearerConfig
    {
        public string Authority { get; set; }
        public string Audience { get; set; }
    }
}
