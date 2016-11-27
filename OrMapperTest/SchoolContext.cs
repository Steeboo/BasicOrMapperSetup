using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrMapperTest
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OR.SchoolContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SchoolContext>());
        }
      
        public DbSet<Leraar> Leraren { get; set; }
    }
}
