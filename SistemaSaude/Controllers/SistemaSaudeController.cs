using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaSaude.Enums;
using SistemaSaude.Model;
using SistemaSaude.Repository;

namespace SistemaSaude.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SistemaSaudeController(IDoctorRepository doctorRepository) : ControllerBase
    {
        private readonly IDoctorRepository _context = doctorRepository;

        [HttpGet("listar-Medicos")]
        public ActionResult<IEnumerable<Doctor>> ListarMedicos([FromQuery] int? size) {
           return Ok(_context.GetDoctors(size).ToList());
        }

        [HttpGet("listar-Medicos/{especialidade}")]
        public ActionResult<IEnumerable<Doctor>> ListarMedicosPorEspecialidade(Roles especialidade, [FromQuery] int? size) {
            var doctors = _context.GetDoctorsByRole(especialidade, size).ToList();
            
            if (doctors is null || doctors.Count == 0){
                return NotFound($"Nenhum médico foi encontrado para a especialidade {especialidade}");
            }
            return Ok(doctors);
        }

        [HttpGet("buscar-Medico/{nome}")]
        public ActionResult<IEnumerable<Doctor>> BuscarMedico(string nome) {
            var doctor = _context.GetDoctorByName(nome);

            return doctor is not null ? Ok(doctor) : NotFound($"Nenhum médico com o nome {nome} foi encontrado!");    
        }
    }
}