using Microsoft.EntityFrameworkCore;
using MvcBasicCore.DAL.DataProviders;
using MvcBasicCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBasicCore.DAL
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext()
        {
            
        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        //private void FixEfProviderServicesProblem()
        //{
        //    // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
        //    // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
        //    // Make sure the provider assembly is available to the running application. 
        //    // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
        //    var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        //}



    }
}
