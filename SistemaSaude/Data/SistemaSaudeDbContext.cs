using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaSaude.Model;

namespace SistemaSaude.Data
{
    public class SistemaSaudeDbContext(DbContextOptions<SistemaSaudeDbContext> options) : DbContext(options)
    {
        public DbSet<Doctor> Medicos { get; set; }
    }
}