using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaSaude.Model
{
    public class User
    {
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string Cpf { get; set; }
        public string? Phone { get; set; }

    }
}