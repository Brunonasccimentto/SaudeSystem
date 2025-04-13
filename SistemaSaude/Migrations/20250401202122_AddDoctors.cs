using Microsoft.EntityFrameworkCore.Migrations;
using SistemaSaude.Enums;

#nullable disable

namespace SistemaSaude.Migrations
{
    /// <inheritdoc />
    public partial class AddDoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql(@$"
            INSERT INTO Medicos(CRM, Roles, Name, Email, Cpf, Phone) VALUES
            ('CRM/SP 123456', '{Roles.Pediatra}', 'João Silva', 'joao.silva@example.com', '123.456.789-00', '(11) 98765-4321'),
            ('CRM/RJ 654321', '{Roles.Psiquiatra}', 'Maria Oliveira', 'maria.oliveira@example.com', '987.654.321-00', '(21) 98765-4321'),
            ('CRM/MG 112233', '{Roles.Geriatra}', 'Pedro Santos', 'pedro.santos@example.com', '112.233.445-00', '(31) 98765-4321'),
            ('CRM/RS 445566', '{Roles.Endocrionogista}', 'Ana Costa', 'ana.costa@example.com', '445.566.778-00', '(51) 98765-4321'),
            ('CRM/BA 778899', '{Roles.Cardiologista}', 'Carlos Pereira', 'carlos.pereira@example.com', '778.899.001-00', '(71) 98765-4321'),
            ('CRM/PR 334455', '{Roles.Ginecologista}', 'Fernanda Lima', 'fernanda.lima@example.com', '334.455.667-00', '(41) 98765-4321'),
            ('CRM/PE 556677', '{Roles.Urologista}', 'Rafael Almeida', 'rafael.almeida@example.com', '556.677.889-00', '(81) 98765-4321'),
            ('CRM/SC 889900', '{Roles.Demartologista}', 'Juliana Souza', 'juliana.souza@example.com', '889.900.112-00', '(48) 98765-4321'),
            ('CRM/GO 223344', '{Roles.ClinicoGeral}', 'Lucas Rodrigues', 'lucas.rodrigues@example.com', '223.344.556-00', '(62) 98765-4321'),
            ('CRM/ES 667788', '{Roles.Angiologista}', 'Mariana Ferreira', 'mariana.ferreira@example.com', '667.788.990-00', '(27) 98765-4321'),
            ('CRM/SP 987654', '{Roles.ClinicoGeral}', 'Eduardo Nunes', 'eduardo.nunes@example.com', '987.654.321-00', '(11) 98765-4321'),
            ('CRM/RJ 123789', '{Roles.Pediatra}', 'Beatriz Mendes', 'beatriz.mendes@example.com', '123.789.456-00', '(21) 98765-4321'),
            ('CRM/MG 456123', '{Roles.Endocrionogista}', 'Felipe Araújo', 'felipe.araujo@example.com', '456.123.789-00', '(31) 98765-4321'),
            ('CRM/RS 789456', '{Roles.ClinicoGeral}', 'Gabriela Martins', 'gabriela.martins@example.com', '789.456.123-00', '(51) 98765-4321'),
            ('CRM/BA 321654', '{Roles.Pediatra}', 'Henrique Souza', 'henrique.souza@example.com', '321.654.987-00', '(71) 98765-4321');
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Medicos");
        }
    }
}
 