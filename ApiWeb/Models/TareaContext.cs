using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Models
{
        public class TareaContext : DbContext
        {
            public TareaContext(DbContextOptions<TareaContext> options)
                : base(options)
            {
            }
            public DbSet<Tarea> Tarea { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"data source=lhdevsolutions.net,40111;Initial Catalog=alumno10;Persist Security Info=True;User ID=alumno10; Password=Mayo2020");
        //}

    }
}
