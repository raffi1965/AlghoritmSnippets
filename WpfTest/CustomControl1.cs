using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfTest
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfTest"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfTest;assembly=WpfTest"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    /// 


    [TemplatePart(Name = "button1", Type=typeof(Button))]
    public class CustomControl1 : Control
    {
        private static int i = 0;

        static CustomControl1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl1), new FrameworkPropertyMetadata(typeof(CustomControl1)));

        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var tb = (Button)GetTemplateChild("button1");

            tb.Click += TbOnClick;
        }

        private void TbOnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            if (sender is Button button)
            {
                button.Content = ++i;
            }

            if (i == 3)
            {
                VisualStateManager.GoToState(this, "state2", false);
                i = 0;
            }
            else
            {
                VisualStateManager.GoToState(this, "state1", false);
            }
        }

        protected override void OnMouseEnter(MouseEventArgs e)
        {
            base.OnMouseEnter(e);
        }
    }
}
