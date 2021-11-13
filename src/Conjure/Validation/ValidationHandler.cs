// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.Validation;

public delegate IEnumerable<ValidationMessage> ValidationHandler<TEntity>(TEntity entity);
