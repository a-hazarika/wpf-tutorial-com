using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpf_tutorial_com
{
    public static class AppCommands
    {
        public static readonly RoutedUICommand Exit = new RoutedUICommand
            (
                "Exit Application",
                "Exit",
                typeof(RoutedUICommand),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.F4, ModifierKeys.Alt, "Exit")
                }
            );
        
        public static readonly RoutedUICommand Cut = new RoutedUICommand
            (
                "Cut Selected Text",
                "Cut",
                typeof(RoutedUICommand),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.NumPad1, ModifierKeys.Control, "Cut")
                }
            );

        public static readonly RoutedUICommand Copy = new RoutedUICommand
            (
                "Copy Selected Text",
                "Copy",
                typeof(RoutedUICommand),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.NumPad2, ModifierKeys.Control, "Copy")
                }
            );

        public static readonly RoutedUICommand Paste = new RoutedUICommand
            (
                "Paste Clipboard Text",
                "Paste",
                typeof(RoutedUICommand),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.NumPad3, ModifierKeys.Control, "Paste")
                }
            );
    }
}
