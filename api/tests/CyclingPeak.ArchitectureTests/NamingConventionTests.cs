using NetArchTest.Rules;
using FluentAssertions;

namespace CyclingPeak.ArchitectureTests;

public class NamingConventionTests
{
    [Fact]
    public void ApplicationInterfaces_Should_StartWith_I()
    {
        var result = Types.InAssembly(typeof(CyclingPeak.Application.Common.Interfaces.ICurrentUserService).Assembly)
            .That()
            .AreInterfaces()
            .Should()
            .HaveNameStartingWith("I")
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "All Application interfaces must start with 'I'");
    }

    [Fact]
    public void ApiControllers_Should_EndWith_Controller()
    {
        var result = Types.InAssembly(typeof(Program).Assembly)
            .That()
            .Inherit(typeof(Microsoft.AspNetCore.Mvc.ControllerBase))
            .Should()
            .HaveNameEndingWith("Controller")
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "All Api controllers must end with 'Controller'");
    }

    [Fact]
    public void InfrastructureConfigurations_Should_EndWith_Configuration()
    {
        var result = Types.InAssembly(typeof(CyclingPeak.Infrastructure.Persistence.AppDbContext).Assembly)
            .That()
            .ImplementInterface(typeof(Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<>))
            .Should()
            .HaveNameEndingWith("Configuration")
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "All EF Core configurations must end with 'Configuration'");
    }
}
