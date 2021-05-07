using Microsoft.Xaml.Interactivity;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace TabViewBehaviorBug.Behaviors
{
    public class HighlightBehavior : Behavior<TextBlock>
    {
        private SolidColorBrush _defaultBrush = new SolidColorBrush(Colors.Black);
        private FontWeight _defaultFontWeight = FontWeights.Normal;

        private SolidColorBrush _highlitedBrush = new SolidColorBrush(Colors.Blue);
        private FontWeight _highlightedFontWeight = FontWeights.Bold;

        protected override void OnAttached()
        {
            AssociatedObject.PointerEntered += OnPointerEntered;
            AssociatedObject.PointerExited += OnPointerExited;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.PointerEntered -= OnPointerEntered;
            AssociatedObject.PointerExited -= OnPointerExited;
        }

        private void OnPointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            AssociatedObject.Foreground = _highlitedBrush;
            AssociatedObject.FontWeight = _highlightedFontWeight;
        }

        private void OnPointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            AssociatedObject.Foreground = _defaultBrush;
            AssociatedObject.FontWeight = _defaultFontWeight;
        }
    }
}
