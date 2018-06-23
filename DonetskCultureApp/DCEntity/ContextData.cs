using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;
using System.Data.Common;
using System.Data.Entity;

namespace DCEntity
{


    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ContextData : DbContext
    {


        public ContextData() : base("MyContext")
        { }

        public DbSet<Establishment> Establishments { get; set; }
    }
}

