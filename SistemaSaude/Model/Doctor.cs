using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using SistemaSaude.Enums;

namespace SistemaSaude.Model
{
    public class Doctor : User
    {
        [Key]
        [StringLength(13)]
        [RegularExpression(@"^CRM\/[A-Z]{2} \d{6}$", ErrorMessage = "O CRM deve estar no formato CRM/XX XXXXXX, onde XX é a sigla do estado e XXXXXX são números")]
        public required string CRM { get; set; }
        public required string Roles { get; set; }
        
    }
}