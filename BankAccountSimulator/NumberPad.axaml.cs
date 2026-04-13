using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BankAccountSimulator;

public partial class NumberPad : UserControl
{
    public NumberPad()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
