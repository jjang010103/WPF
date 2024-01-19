using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KinderGarten.Behavior
{
    internal class FrameBehavior : Behavior<Frame>
    {
        public static readonly DependencyProperty NavigationPathDp = DependencyProperty.Register(nameof(NavigationPath), typeof(string),
                                                        typeof(FrameBehavior), new PropertyMetadata(null, NavigationSourceChanged));

        private static void NavigationSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var behavior = (FrameBehavior)d;

            behavior.Navigate();
        }

        public string NavigationPath
        {
            get
            {
                return (string)GetValue(NavigationPathDp);
            }
            set
            {
                SetValue(NavigationPathDp, value);
            }
        }

        private void Navigate()
        {
            if(!string.IsNullOrEmpty(this.NavigationPath))
            {
                this.AssociatedObject.Navigate(new Uri(this.NavigationPath, UriKind.RelativeOrAbsolute));
            }
        }
    }
}
