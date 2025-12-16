using Microsoft.AspNetCore.Components;

namespace DevToys.Blazor.Core;

internal sealed class UIAsyncInvoker : ComponentBase, Api.IUIAsyncInvoker
{
    public void AsyncInvoker(EventHandler handler)
    {
        InvokeAsync(() => handler(null, EventArgs.Empty));
    }
}