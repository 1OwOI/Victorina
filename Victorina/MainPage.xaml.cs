namespace Victorina
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnStartClicked(object sender, EventArgs e) 
        {
            await Shell.Current.GoToAsync("quiz");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Информация о приложении","Сделал Дрис Олег Иванович\nГуппы:24сиб2","Закрыть");
        }
    }
}
