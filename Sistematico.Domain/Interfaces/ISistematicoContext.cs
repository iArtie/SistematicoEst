using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Sistematico.Domain.Entities;

namespace Sistematico.Domain.Interfaces
{
    public interface ISistematicoContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public int SaveChanges();
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
