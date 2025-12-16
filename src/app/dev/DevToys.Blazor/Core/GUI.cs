using DevToys.Api;

namespace DevToys.Blazor.Core;

public static partial class GUI
{
    internal static IUIAsyncInvoker? UIAsyncInvokerInstance { get; set; }

    public static IUIAsyncInvoker GetUIAsyncInvoker()
    {
        return UIAsyncInvokerInstance!;
    }
}