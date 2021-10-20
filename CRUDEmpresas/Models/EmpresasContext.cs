using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDEmpresas.Models
{
    public class EmpresasContext: DbContext
    {
        public EmpresasContext(DbContextOptions<EmpresasContext>options) :base(options)
        {

        }

        public DbSet<Empresas> Empresass { get; set; }
    }
}
