namespace tessting;

public partial class AppShell : Shell {
    public AppShell() {
        InitializeComponent();

        RenderBasedOnDevice(DeviceInfo.Idiom);
    }

    public void RenderBasedOnDevice(DeviceIdiom idiom) {

        var itemsToRemove = new List<ShellItem>();

        foreach (var item in Items) {
            if ((idiom == DeviceIdiom.Phone && item is FlyoutItem) ||
                (idiom == DeviceIdiom.Desktop && item is TabBar)) {
                itemsToRemove.Add(item);
            }
        }

        foreach (var item in itemsToRemove) {
            Items.Remove(item);
        }

    }
}
