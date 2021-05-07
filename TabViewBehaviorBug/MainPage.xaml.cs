using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TabViewBehaviorBug
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SecondPage));
        }
    }
}
