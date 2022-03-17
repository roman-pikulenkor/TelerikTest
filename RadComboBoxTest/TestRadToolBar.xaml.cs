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
    public partial class TestRadToolBar : Page
    {
        public TestRadToolBar()
        {
            this.InitializeComponent();
        }

        private void FileButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("File clicked");
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Edit clicked");
        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("View clicked");
        }

        private void View1Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("View1 clicked");
        }

        private void View2Button_Click(object sender, RoutedEventArgs e)
        {
            toolbar.IsOverflowOpen = false;
            Console.WriteLine("View2 clicked");
        }

        private void View3Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("View3 clicked");
        }

        private void View4Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("View4 clicked");
        }
    }
}
