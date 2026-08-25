using NetArchTest.Rules;
using FluentAssertions;

namespace CyclingPeak.ArchitectureTests;

public class LayerDependencyTests
{
    private const string DomainNamespace         = "CyclingPeak.Domain";
    private const string ApplicationNamespace    = "CyclingPeak.Application";
    private const string InfrastructureNamespace = "CyclingPeak.Infrastructure";
    private const string ApiNamespace            = "CyclingPeak.Api";

    [Fact]
    public void Domain_ShouldNot_DependOn_Infrastructure()
    {
        var result = Types.InAssembly(typeof(CyclingPeak.Domain.Entities.User).Assembly)
            .ShouldNot()
            .HaveDependencyOn(InfrastructureNamespace)
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "Domain must not depend on Infrastructure");
    }

    [Fact]
    public void Domain_ShouldNot_DependOn_Application()
    {
        var result = Types.InAssembly(typeof(CyclingPeak.Domain.Entities.User).Assembly)
            .ShouldNot()
            .HaveDependencyOn(ApplicationNamespace)
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "Domain must not depend on Application");
    }

    [Fact]
    public void Domain_ShouldNot_DependOn_Api()
    {
        var result = Types.InAssembly(typeof(CyclingPeak.Domain.Entities.User).Assembly)
            .ShouldNot()
            .HaveDependencyOn(ApiNamespace)
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "Domain must not depend on Api");
    }

    [Fact]
    public void Application_ShouldNot_DependOn_Infrastructure()
    {
        var result = Types.InAssembly(typeof(CyclingPeak.Application.Common.Interfaces.ICurrentUserService).Assembly)
            .ShouldNot()
            .HaveDependencyOn(InfrastructureNamespace)
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "Application must not depend on Infrastructure");
    }

    [Fact]
    public void Application_ShouldNot_DependOn_Api()
    {
        var result = Types.InAssembly(typeof(CyclingPeak.Application.Common.Interfaces.ICurrentUserService).Assembly)
            .ShouldNot()
            .HaveDependencyOn(ApiNamespace)
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "Application must not depend on Api");
    }
}
