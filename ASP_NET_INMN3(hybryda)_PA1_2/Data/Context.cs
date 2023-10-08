using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_NET_INMN3_hybryda__PA1_2.Models;

namespace ASP_NET_INMN3_hybryda__PA1_2.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Miasto> Miasta { get; set; } = default!;
    }
}
