using Microsoft.CodeAnalysis;

namespace ListExceptions2
{
    public class DocumentInfo
    {
        public SyntaxNode Node { get; set; }
        public SemanticModel Model { get; set; }
    }
}