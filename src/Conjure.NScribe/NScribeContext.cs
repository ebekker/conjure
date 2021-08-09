using Microsoft.CodeAnalysis;

namespace Conjure.NScribe
{
    public class NScribeContext
    {
        private GeneratorExecutionContext _context;

        public NScribeContext(GeneratorExecutionContext context)
        {
            _context = context;
        }

        public GeneratorExecutionContext GeneratorContext => _context;

        // public SymbolDisplayFormat SDF => SymbolDisplayFormat.FullyQualifiedFormat;

        // public string EntryPointClassName => _context.Compilation.GetEntryPoint(default).ContainingType.Name;
        // public string EntryPointNamespace => _context.Compilation.GetEntryPoint(default).ContainingNamespace.Name;
        // public string EntryPointNamespaceDisplayName => _context.Compilation.GetEntryPoint(default).ContainingNamespace.ToDisplayString();
    }
}