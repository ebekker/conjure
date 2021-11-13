// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.Validation;

public interface ISelfValidating
{
    // We should only validate simple data typed fields since relationships
    // fields may not be populated if not "Included" in the original query

    IEnumerable<ValidationMessage> Validate();
}
