using System.Windows;

namespace MahApps.Metro.Controls
{
    public class ContextMenuHelper
    {
        public static readonly DependencyProperty IsContextMenuBoundProperty
            = DependencyProperty.RegisterAttached(
                "IsContextMenuBound",
                typeof(bool?),
                typeof(ContextMenuHelper),
                new FrameworkPropertyMetadata(default(bool?)));

        public static void SetIsContextMenuBound(DependencyObject element, bool? value)
        {
            element.SetValue(IsContextMenuBoundProperty, value);
        }

        public static bool? GetIsContextMenuBound(DependencyObject element)
        {
            return (bool?)element.GetValue(IsContextMenuBoundProperty);
        }

        public static readonly DependencyProperty IsContextMenuVisibleProperty
            = DependencyProperty.RegisterAttached(
                "IsContextMenuVisible",
                typeof(bool?),
                typeof(ContextMenuHelper),
                new FrameworkPropertyMetadata((bool?)true));

        public static void SetIsContextMenuVisible(DependencyObject element, bool? value)
        {
            element.SetValue(IsContextMenuVisibleProperty, value);
        }

        public static bool? GetIsContextMenuVisible(DependencyObject element)
        {
            return (bool?)element.GetValue(IsContextMenuVisibleProperty);
        }
    }
}