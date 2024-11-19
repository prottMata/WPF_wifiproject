using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1
{
    public class WifiNetworkContext : DbContext
    {
        public DbSet<WifiNetwork> WifiNetworks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=LocalDB.db");
    }
}
