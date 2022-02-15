using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace RadComboBoxTest
{
    public partial class TestSISEControls : Page
    {
        public TestSISEControls()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChildWindowPopupRadGrid child = new ChildWindowPopupRadGrid();
            child.Show();
        }
    }
}
