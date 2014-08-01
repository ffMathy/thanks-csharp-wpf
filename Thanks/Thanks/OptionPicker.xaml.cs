using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Thanks
{
    /// <summary>
    /// Interaction logic for OptionPicker.xaml
    /// </summary>
    [ContentProperty("Children")]
    public partial class OptionPicker : UserControl
    {
        public OptionPicker()
        {
            InitializeComponent();

            Children = new UIElementCollection(MainItemsControl, MainItemsControl);
        }

        public static readonly DependencyPropertyKey ChildrenProperty = DependencyProperty.RegisterReadOnly(
            "Children",
            typeof(UIElementCollection),
            typeof(OptionPicker),
            new PropertyMetadata());

        public UIElementCollection Children
        {
            get { return (UIElementCollection)GetValue(ChildrenProperty.DependencyProperty); }
            private set { SetValue(ChildrenProperty, value); }
        }

    }
}
