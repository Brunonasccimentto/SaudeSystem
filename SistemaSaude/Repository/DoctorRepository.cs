using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaSaude.Data;
using SistemaSaude.Enums;
using SistemaSaude.Model;

namespace SistemaSaude.Repository
{
    public class DoctorRepository(SistemaSaudeDbContext context) : IDoctorRepository
    {
        public Doctor? GetDoctorByName(string name)
        {
            return context.Medicos.FirstOrDefault(doctor => doctor.Name == name);
        }

        public IEnumerable<Doctor> GetDoctors(int? size)
        {
            return [.. context.Medicos.AsNoTracking()
            .OrderBy(doctor => doctor.Name)
            .Take(size ?? 15)];
        }

        public IEnumerable<Doctor> GetDoctorsByRole(Roles role, int? size)
        {
            return [.. context.Medicos.AsNoTracking()
            .Where(doctor => doctor.Roles == role.ToString())
            .Take(size ?? 15)
            .OrderBy(doctor => doctor.Name)];
        }

    }
}