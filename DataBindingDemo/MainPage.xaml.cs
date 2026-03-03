using DataBindingDemo.Services;

namespace DataBindingDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void RefreshWeatherButton_Clicked(object sender, EventArgs e)
        {

            // 1. Send data to the service
            WeatherService.Location = PostalCode.Text;

            // 2. Tell service to update
            WeatherService.Refresh();

            // 3. Manually push data back to the UI
            Humidity.Text = $"Humidity: {WeatherService.Humidity}";
        }
    }
}
