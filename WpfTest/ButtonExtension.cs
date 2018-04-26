using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace WpfTest
{
    public class ButtonExtension: DependencyObject
    {
        public static readonly DependencyProperty BorderBrushProperty = DependencyProperty.RegisterAttached("BorderBrush", typeof(Brush), typeof(ButtonExtension), new PropertyMetadata(null, PropertyChangedCallback));

        public static Brush GetBorderBrush(Button target)
        {
            return (Brush)target.GetValue(BorderBrushProperty);
        }

        public static void SetBorderBrush(Button target, Brush value)
        {
            target.SetValue(BorderBrushProperty, value);
        }

        public static void ClearBorderBrush()
        {
            
        }

        private static void PropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            if (dependencyObject is Button button)
            {
                button.BorderBrush = (Brush)dependencyPropertyChangedEventArgs.NewValue;
                button.Loaded += ButtonOnLoaded;
            }
        }

        private static void ButtonOnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            if (sender is Button button)
            {
                button.Loaded -= ButtonOnLoaded;
                var myAdornerLayer = AdornerLayer.GetAdornerLayer(button);
                myAdornerLayer.Add(new SimpleCircleAdorner(button));
            }
        }
    }
}
