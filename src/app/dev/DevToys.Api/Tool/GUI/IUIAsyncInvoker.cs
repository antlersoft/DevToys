namespace DevToys.Api;

public interface IUIAsyncInvoker
{
    void AsyncInvoker(EventHandler handler);
}

public static partial class GUI
{
    internal static IUIAsyncInvoker? UIAsyncInvokerInstance { get; set; }

    public static IUIAsyncInvoker GetUIAsyncInvoker()
    {
        return UIAsyncInvokerInstance!;
    }
}