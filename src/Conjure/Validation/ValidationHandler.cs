namespace Conjure.Validation;

public delegate IEnumerable<ValidationMessage> ValidationHandler<TEntity>(TEntity entity);
