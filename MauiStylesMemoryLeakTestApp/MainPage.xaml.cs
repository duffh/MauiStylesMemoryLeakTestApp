namespace MauiStylesMemoryLeakTestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenStyledPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StyledPage());
        }

        private async void OpenUnstyledPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UnstyledPage());
        }

        private void GCCollectButton_Clicked(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}