using API_TCC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API_TCC.Controllers.Database
{
    public class Context_db : DbContext
    {
        public Context_db() : base("name=Partiu")
        {

        }
        
        public DbSet<Model_eventos> Eventos { get; set; }
        public DbSet<Model_usuarios> Usuarios { get; set; }
        public DbSet<Model_divulgadores> Divulgadores { get; set; }
    }
}