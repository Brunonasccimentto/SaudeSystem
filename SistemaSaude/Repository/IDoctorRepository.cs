using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaSaude.Enums;
using SistemaSaude.Model;

namespace SistemaSaude.Repository
{
    public interface IDoctorRepository
    {
        // Poderia ter criado um Repositorio Generico aqui que implementaria IRepositorio com médotos do Crud
        // Porem para essa atividade não faz sentido Implementar no momento. Quem sabe uma refatoração futura :)
        // Metodo GetDoctors seria um GetAll genérico
         public IEnumerable<Doctor> GetDoctors(int? size);
         public IEnumerable<Doctor> GetDoctorsByRole(Roles role, int? size);
         public Doctor? GetDoctorByName(string name);
    }
}