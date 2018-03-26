using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;
using MySql.Data;
using System.Data.Common;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DonetskCulture
{
    //Example class for working with EntityFramework
    
    public class Establishment
    {
        [Key]
        public int id_establishment { get; set; }
        public string name { get; set; }

        public string regionOrCity { get; set; }

        public string address { get; set; }

        public string formWork { get; set; }

        public string state { get; set; }
    }

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class DesktopDBContext : DbContext
    {
        public DesktopDBContext() : base("connectDB")
        { }

        // Constructor to use on a DbConnection that is already opened
        public DesktopDBContext(DbConnection existingConnection, bool contextOwnsConnection)
          : base(existingConnection, contextOwnsConnection)
        {

        }



        public DbSet<Establishment> Establishments { get; set; }
    }


}
