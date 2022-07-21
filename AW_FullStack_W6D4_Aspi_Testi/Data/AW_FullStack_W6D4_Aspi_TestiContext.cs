using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AW_FullStack_W6D4_Aspi_Testi.Models;

namespace AW_FullStack_W6D4_Aspi_Testi.Data
{
    public class AW_FullStack_W6D4_Aspi_TestiContext : DbContext
    {
        public AW_FullStack_W6D4_Aspi_TestiContext (DbContextOptions<AW_FullStack_W6D4_Aspi_TestiContext> options)
            : base(options)
        {
        }

        public DbSet<AW_FullStack_W6D4_Aspi_Testi.Models.Topic> Topic { get; set; }
    }
}
