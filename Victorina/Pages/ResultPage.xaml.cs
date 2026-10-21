namespace Victorina.Pages;

[QueryProperty(nameof(Score), "score")]
[QueryProperty(nameof(Total), "total")]
public partial class ResultPage : ContentPage
{
    private int _score;

    private int _total;

    public int Score 
    {
        get => _score;
        set { _score = value; UpdateLabel(); }
    }

    public int Total
    {
        get => _total;
        set { _total = value; UpdateLabel(); }
    }

    public ResultPage() => InitializeComponent();

    private void UpdateLabel() 
    {
        if (_total > 0)
            ResultLabel.Text = $"Верно: {_score} из {_total}";
    }

    private async void OnRestartClicked(object sender, EventArgs e) 
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}