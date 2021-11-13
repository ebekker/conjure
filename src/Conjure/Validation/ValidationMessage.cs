// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.Validation
{

    public class ValidationMessage
    {
        public ValidationMessage(string message,
            params string[] members)
        {
            Message = message;
            Members = members;
        }
        public ValidationMessage(string message,
            ValidationSeverity severity,
            params string[] members)
        {
            Message = message;
            Severity = severity;
            Members = members;
        }

        public string Message { get; init; }

        public ValidationSeverity Severity { get; init; }

        public IEnumerable<string> Members { get; init; }
    }
}
