using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Media3D;

namespace ViewSlide.Command
{
    public class WindowKeyDown_Space
    {
        private static readonly RoutedUICommand _instance = new RoutedUICommand("", nameof(Instance), typeof(WindowKeyDown_Space));

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
            foreach (Window w in Application.Current.Windows)
            {
                if (w.DataContext is ViewModel.BaseViewModel_Window bvm)
                {
                    bvm.MoveNextScreenLocation();
                }
            }
        }
    }
}
