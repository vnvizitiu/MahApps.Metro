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
                new FrameworkPropertyMetadata((bool?)true, IsContextMenuVisibleChanged));

        private static void IsContextMenuVisibleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var fe = d as FrameworkElement;
            if (fe != null && e.OldValue != e.NewValue)
            {
                fe.ContextMenuOpening -= FrameworkElementContextMenuOpening;
                fe.ContextMenuOpening += FrameworkElementContextMenuOpening;
            }
        }

        private static void FrameworkElementContextMenuOpening(object sender, System.Windows.Controls.ContextMenuEventArgs e)
        {
            var fe = (FrameworkElement)sender;
            var isContextMenuVisible = GetIsContextMenuVisible(fe).GetValueOrDefault(true);
            if (!isContextMenuVisible)
            {
                fe.ContextMenu = null;
            }
        }

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