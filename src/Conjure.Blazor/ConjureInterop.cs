namespace Conjure.Blazor;

using Microsoft.JSInterop;

public class ConjureInterop : IAsyncDisposable
{
    private readonly IJSRuntime _jSRuntime;
    private readonly Lazy<Task<IJSObjectReference>> _moduleTask;

    public ConjureInterop(IJSRuntime jsRuntime)
    {
        _jSRuntime = jsRuntime;
        _moduleTask = new (() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/Conjure.Blazor/conjure-interop.js").AsTask());
    }

    public async ValueTask DisposeAsync()
    {
        if (_moduleTask.IsValueCreated)
        {
            var module = await _moduleTask.Value;
            await module.DisposeAsync();
        }
    }

    public async ValueTask CopyToClipboard(string text)
    {
        await _jSRuntime.InvokeVoidAsync("navigator.clipboard.writeText", text);
    }

    public async ValueTask<string> CopyFromClipboard()
    {
        return await _jSRuntime.InvokeAsync<string>("navigator.clipboard.readText");
    }

    public async ValueTask<string> Prompt(string message)
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<string>("showPrompt", message);
    }

    public async ValueTask<TValue> GetProperty<TValue>(IJSObjectReference target, string property)
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<TValue>("getProperty", target, property);
    }

    public async ValueTask SetProperty<TValue>(IJSObjectReference target, string property, TValue value)
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("setProperty", target, property, value);
    }

    public async ValueTask DownloadSaveAs(string filename, string content)
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("downloadSaveAs", filename, content);
    }

    public async ValueTask UnloadEnable()
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("unloadEnable");
    }

    public async ValueTask UnloadDisable()
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("unloadDisable");
    }
}
