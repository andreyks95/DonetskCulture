using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCEntity
{
    public class Establishment
    {

        //[Key]
        public int Id_establishment { get; set; }
        public string Name { get; set; }
        public string RegionOrCity { get; set; }
        public string Address { get; set; }
        public string FormWork { get; set; }
        public string State { get; set; }
    }
}
