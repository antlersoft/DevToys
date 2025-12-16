using Microsoft.AspNetCore.Components;

namespace DevToys.Blazor.Core;

public sealed class UIAsyncInvoker : Api.IUIAsyncInvoker
{
    private ComponentBase? _component;

    public void SetComponent(ComponentBase component)
    {
        _component = component;
    }

    public void AsyncInvoker(EventHandler handler)
    {
        _component?.InvokeAsync(() => handler(null, EventArgs.Empty));
    }
}