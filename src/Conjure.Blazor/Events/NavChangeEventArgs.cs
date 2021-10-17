namespace Conjure.Blazor.Events;

public class NavChangeEventArgs
{
    public string? NewUri { get; init; }

    public Func<Task<bool>>? Cancel { get; set; }
}
