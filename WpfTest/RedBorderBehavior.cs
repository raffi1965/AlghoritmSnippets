using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace WpfTest
{
    public class RedBorderBehavior: Behavior<Button>
    {
        public static readonly DependencyProperty BorderBrushProperty = DependencyProperty.Register(nameof(BorderBrush), typeof(Brush), typeof(RedBorderBehavior), new PropertyMetadata(Brushes.Red));

        public Brush BorderBrush
        {
            get => (Brush) GetValue(BorderBrushProperty);
            set => SetValue(BorderBrushProperty, value);
        }

        protected override void OnAttached()
        {
            base.OnAttached();

            AssociatedObject.BorderBrush = BorderBrush;
            AssociatedObject.BorderThickness = new Thickness(2);
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            
        }
    }
}