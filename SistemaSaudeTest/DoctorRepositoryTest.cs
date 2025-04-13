using Microsoft.EntityFrameworkCore;
using Moq;
using SistemaSaude.Data;
using SistemaSaude.Enums;
using SistemaSaude.Model;
using SistemaSaude.Repository;

namespace SistemaSaudeTest;

public class DoctorRepositoryTests
{
    private static SistemaSaudeDbContext MockDbContext()
    {
        var options = new DbContextOptionsBuilder<SistemaSaudeDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        var context = new SistemaSaudeDbContext(options);
        SeedData(context);
        return context;
    }

    private static void SeedData(SistemaSaudeDbContext context)
    {
        context.Medicos.AddRange(new List<Doctor>
        {
            new() {
                CRM = "CRM/SP 123456",
                Roles = Roles.Pediatra.ToString(),
                Name = "João Silva",
                Email = "joao.silva@example.com",
                Cpf = "123.456.789-00",
                Phone = "(11) 98765-4321"
            },
            new() {
                CRM = "CRM/RJ 654321",
                Roles = Roles.Psiquiatra.ToString(),
                Name = "Maria Oliveira",
                Email = "maria.oliveira@example.com",
                Cpf = "987.654.321-00",
                Phone = "(21) 98765-4321"
            },
            new() {
                CRM = "CRM/MG 112233",
                Roles = Roles.Geriatra.ToString(),
                Name = "Pedro Santos",
                Email = "pedro.santos@example.com",
                Cpf = "112.233.445-00",
                Phone = "(31) 98765-4321"
            },
            new() {
                CRM = "CRM/RS 445566",
                Roles = Roles.Endocrionogista.ToString(),
                Name = "Ana Costa",
                Email = "ana.costa@example.com",
                Cpf = "445.566.778-00",
                Phone = "(51) 98765-4321"
            },
            new() {
                CRM = "CRM/BA 778899",
                Roles = Roles.Cardiologista.ToString(),
                Name = "Carlos Pereira",
                Email = "carlos.pereira@example.com",
                Cpf = "778.899.001-00",
                Phone = "(71) 98765-4321"
            }
        });

        context.SaveChanges();
    }

    [Fact]
    public void GetDoctorByName_ShouldReturnCorrectDoctor()
    {
        var context = MockDbContext();
        var repo = new DoctorRepository(context);

        var doctor = repo.GetDoctorByName("Carlos Pereira");

        Assert.NotNull(doctor);
        Assert.Equal("Carlos Pereira", doctor!.Name);
    }

    [Fact]
    public void GetDoctors_ShouldReturnOrderedDoctors()
    {
        var context = MockDbContext();
        var repo = new DoctorRepository(context);

        var doctors = repo.GetDoctors(null).ToList();

        Assert.Equal(5, doctors.Count);
        Assert.True(doctors.SequenceEqual(doctors.OrderBy(d => d.Name)));
    }

    [Fact]
    public void GetDoctors_ShouldRespectLimit()
    {
        var context = MockDbContext();
        var repo = new DoctorRepository(context);

        var doctors = repo.GetDoctors(2).ToList();

        Assert.Equal(2, doctors.Count);
    }

    [Fact]
    public void GetDoctorsByRole_ShouldReturnFilteredDoctors()
    {
        var context = MockDbContext();
        var repo = new DoctorRepository(context);

        var doctors = repo.GetDoctorsByRole(Roles.Cardiologista, null).ToList();

        Assert.Single(doctors);
        Assert.All(doctors, d => Assert.Equal(Roles.Cardiologista.ToString(), d.Roles));
    }

    [Fact]
    public void GetDoctorsByRole_ShouldRespectLimit()
    {
        var context = MockDbContext();
        var repo = new DoctorRepository(context);

        var doctors = repo.GetDoctorsByRole(Roles.Pediatra, 1).ToList();

        Assert.Single(doctors);
        Assert.Equal(Roles.Pediatra.ToString(), doctors[0].Roles);
    }
}
