using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Learning.Avalonia.GetStartedApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        if (double.TryParse(Celsius.Text, out var celsius))
        {
            var fahrenheit = celsius * (9d / 5d) + 32;
            Fahrenheit.Text = fahrenheit.ToString("0.0");
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }
    }
}
