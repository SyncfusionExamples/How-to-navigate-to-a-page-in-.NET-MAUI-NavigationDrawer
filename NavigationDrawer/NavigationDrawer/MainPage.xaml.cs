using Microsoft.Maui.Platform;


namespace NavigationDrawer {
    public partial class MainPage : ContentPage {
        

        public MainPage() {
            InitializeComponent();
        }
        private async void Bt_Clicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new NewPage());
        }
        private void hamburgerButton_Clicked(object sender, EventArgs e) {
            navigationDrawer.ToggleDrawer();
        }

    }

}
