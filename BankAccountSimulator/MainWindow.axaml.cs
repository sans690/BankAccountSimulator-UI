using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace BankAccountSimulator;

public partial class MainWindow : Window
{
    List<User> users = new List<User>
    {
        new User("Larry", "Smith", "1", "111", "100"),
        new User("Ben", "Jackson", "2", "222", "50")
    };

    public MainWindow()
    {
        InitializeComponent();
    }

    public void HandleSignInClick(object? sender, RoutedEventArgs e)
    {
        var cardNumberInput = this.FindControl<TextBox>("cardNumber");
        var cardPinInput = this.FindControl<TextBox>("cardPin");
        var result = this.FindControl<TextBlock>("resultText");

        var loginPanel = this.FindControl<StackPanel>("LoginPanel");
        var dashboardPanel = this.FindControl<StackPanel>("DashboardPanel");

        if (cardNumberInput == null || cardPinInput == null || resultText == null || loginPanel == null || dashboardPanel == null)
        {
            return;
        }

        string? card = cardNumberInput.Text;
        string? pin = cardPinInput.Text;

        bool isValid = false;

        foreach (User u in users)
        {
            if (u.cardNumber == card && u.cardPin == pin)
            {
                isValid = true;
                break;
            }
        }

        if (isValid)
        {
            loginPanel.IsVisible = false;
            dashboardPanel.IsVisible = true;
        }

        else
        {
            result?.Text = "Invalid login";
        }
    }
}












