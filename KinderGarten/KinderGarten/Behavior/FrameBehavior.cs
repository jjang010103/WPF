using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;

namespace KinderGarten.Behavior
{
    public class FrameBehavior : Behavior<Frame>
    {
        public static readonly DependencyProperty NavigationPathDp = DependencyProperty.Register(nameof(NavigationPage), typeof(Page),
                                                        typeof(FrameBehavior), new PropertyMetadata(null, NavigationSourceChanged));

        private static void NavigationSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var behavior = (FrameBehavior)d;

            behavior.Navigate();
        }

        public Page NavigationPage
        {
            get
            {
                return (Page)GetValue(NavigationPathDp);
            }
            set
            {
                SetValue(NavigationPathDp, value);
            }
        }

        private void Navigate()
        {
            this.AssociatedObject.Navigate(this.NavigationPage);
        }
    }
}
