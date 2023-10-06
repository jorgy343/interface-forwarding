using Microsoft.CodeAnalysis;

namespace Jorgy.InterfaceForwarding;

[Generator(LanguageNames.CSharp)]
public class InterfaceForwardingGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {

    }
}