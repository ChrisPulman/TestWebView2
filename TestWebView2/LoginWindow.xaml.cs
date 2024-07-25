using ReactiveMarbles.ObservableEvents;

namespace TestWebView2;

public partial class LoginWindow
{
    public LoginWindow()
    {
        InitializeComponent();
        LoginButton.Events().Click.Subscribe(_ => DialogResult = true);
        this.Events().Closing.Subscribe(_ => DialogResult = false);
    }
}