using LiquorAdda.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquorAdda.Core.DataContext
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            //Debug.Write();
        }

        public DbSet<Liquor> Liquors { get; set; }
    }
}
