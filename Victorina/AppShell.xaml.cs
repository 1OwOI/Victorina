using Victorina.Pages;

namespace Victorina
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("quiz", typeof(QuizPage));
            Routing.RegisterRoute("result", typeof(ResultPage));
        }
    }
}
