namespace Demo_Pages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var navPage = new NavigationPage(new MainPage());

            navPage.Background = Colors.Chocolate;
            navPage.BarTextColor = Colors.White;

            MainPage = navPage;
        }

        
    }
}