using Conjure.BlazorKit.Data;

namespace Conjure.BlazorKit;

public abstract class ScreenBase : ComponentBase, IDisposable
{
    public virtual string? Label { get; set; }

    public virtual bool CanExecute { get; set; } = true;

    public virtual DataWorkspaceBase? GetDataWorkspace() => null;

    public virtual void Dispose()
    { }
}

public abstract class ScreenBase<TDataWorkspace> : ScreenBase
    where TDataWorkspace : DataWorkspaceBase
{

    [Inject] protected TDataWorkspace DWS { get; set; } = default!;

    public override TDataWorkspace? GetDataWorkspace() => DWS;

    public override void Dispose()
    {
        DWS?.Dispose();
        base.Dispose();
    }
}
