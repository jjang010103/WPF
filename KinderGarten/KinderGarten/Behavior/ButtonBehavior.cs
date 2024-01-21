using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace KinderGarten.Behavior
{
    public class ButtonBehavior : Behavior<Button>
    {
        public static readonly DependencyProperty CmdClickDp = DependencyProperty.Register(nameof(CmdClick), typeof(ICommand),
                                                                            typeof(ButtonBehavior), new PropertyMetadata(null));

        public ICommand CmdClick
        {
            get
            {
                return (ICommand)this.GetValue(CmdClickDp);
            }
            set
            {
                this.SetValue(CmdClickDp, value);
            }
        }

        protected override void OnAttached()
        {
            this.AssociatedObject.Click += this.AssociatedObject_Click;
        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.Click -= this.AssociatedObject_Click;
        }

        private void AssociatedObject_Click(object sender, EventArgs e)
        {
            if (this.CmdClick != null)
            {
                this.CmdClick.Execute(e);
            }
        }
    }
}
