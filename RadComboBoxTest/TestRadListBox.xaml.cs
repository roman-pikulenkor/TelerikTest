using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class TestRadListBox : Page
    {
        List<string> source = new List<string>();

        ListBoxViewModel viewModel = new ListBoxViewModel();
        public TestRadListBox()
        {
            this.InitializeComponent();

            this.Loaded += Page_Loaded;
            
            
            /*for (int i = 0; i < 12; i++)
            {
                source.Add(i.ToString() + ".ABC");
            }
            radListBox.ItemsSource = source;*/
            

            
            /*for (int i = 0; i < 10; i++)
            {
                viewModel.BoxItems.Add(i.ToString() + ".BBBBB");
            }*/

            radListBox.DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                viewModel.BoxItems.Add(i.ToString() + ".BBBBB");
            }
            */

            radListBox.Visibility = radListBox.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                viewModel.BoxItems.Add(i.ToString() + ".BBBBB");
            }
        }

    }

    public class ListBoxViewModel
    {
        public List<string> BoxItems = new List<string>();

        public ListBoxViewModel()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    BoxItems.Add(i.ToString() + ".AAAAA");
            //}
        }
    }
}
