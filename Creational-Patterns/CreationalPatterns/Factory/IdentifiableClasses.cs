using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Factory
{
    public class SomethingCoolA : IIdentifiable
    {
        public string PropertyA { get; set; } = Path.GetRandomFileName();

        public int ID { get; set; }
    }

    public class SomethingCoolB : IIdentifiable
    {
        public string PropertyB { get; set; } = Path.GetRandomFileName();

        public int ID { get; set; }
    }
}
