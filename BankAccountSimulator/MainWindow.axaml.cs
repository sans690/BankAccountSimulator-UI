using Avalonia.Controls;
using Avalonia.Interactivity;

namespace BankAccountSimulator;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void HandleSignInClick(object? sender, RoutedEventArgs e)
    {
        var cardNumberInput = this.FindControl<TextBox>("cardNumber");
        var cardPinInput = this.FindControl<TextBox>("cardPin");
        var result1 = this.FindControl<TextBlock>("resultText1");
        var result2 = this.FindControl<TextBlock>("resultText2");

        result1?.Text = cardNumberInput?.Text;
        result2?.Text = cardPinInput?.Text;
    }
}