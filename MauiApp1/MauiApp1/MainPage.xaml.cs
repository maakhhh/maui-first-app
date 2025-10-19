namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        Fio.Text = string.Empty;
        Age.Value = 30;
        Gender.IsChecked = true;
        Agreement.IsChecked = false;
        Phone.Text = string.Empty;
    }

    private void Agreement_OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        Submit.IsEnabled = e.Value;
    }

    private void Phone_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (sender is not Entry entry)
            return;

        var digitsOnly = new string([.. e.NewTextValue.Where(char.IsDigit)]);

        if (e.NewTextValue != digitsOnly)
            entry.Text = digitsOnly;

        entry.TextColor = digitsOnly.Length == 10 ? Colors.Green : Colors.Red;
    }

    private void TapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
    {
        Agreement.IsChecked = !Agreement.IsChecked;
    }
}
