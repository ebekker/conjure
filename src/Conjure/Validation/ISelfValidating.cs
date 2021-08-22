namespace Conjure.Validation;

public interface ISelfValidating
{
    IEnumerable<ValidationMessage> Validate();
}
