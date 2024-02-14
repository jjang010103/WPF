using System;
using System.Windows;
using System.Windows.Input;

namespace ViewSlide.Command
{
    public class WindowKeyDown_esc
    {
        private static readonly RoutedUICommand _instance = new RoutedUICommand("", nameof(Instance), typeof(WindowKeyDown_esc));

        public static RoutedUICommand Instance
        {
            get
            {
                return _instance;
            }
        }

        public void InsertCommand()
        {
            var cmdBinding_KeyDownEsc = new CommandBinding(Instance, Excute, (s, e) => { e.CanExecute = true; });

            CommandManager.RegisterClassCommandBinding(typeof(Window), cmdBinding_KeyDownEsc);
        }

        public void Excute(object sender, ExecutedRoutedEventArgs e)
        {
            App.Current.Release();
        }
    }
}
