using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDI
{
    public class GuidGenerator : IGuidGenerator
    {
        public GuidGenerator()
        {
            Guid1 = Guid.NewGuid().ToString();
        }
        public string Guid1 { get; set; }

        public string GetGuid()
        {
            return Guid1;
        }
    }
}
