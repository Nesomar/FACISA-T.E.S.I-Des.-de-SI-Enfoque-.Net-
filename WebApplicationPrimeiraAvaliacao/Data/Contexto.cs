using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplicationPrimeiraAvaliacao.Models;

namespace WebApplicationPrimeiraAvaliacao.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
    }
}