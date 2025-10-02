using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ReSharperPlugin.ScopeToThis.Tests
{
    [ZoneDefinition]
    public class ScopeToThisTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IScopeToThisZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<ScopeToThisTestEnvironmentZone> { }

    [SetUpFixture]
    public class ScopeToThisTestsAssembly : ExtensionTestEnvironmentAssembly<ScopeToThisTestEnvironmentZone> { }
}
