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
using Telerik.Windows.Controls;

namespace RadComboBoxTest
{
    public partial class TestRadComboBox : Page
    {
        List<string> source = new List<string>();
        bool bUseItemsSource = false;

        public TestRadComboBox()
        {
            this.InitializeComponent();

            if (bUseItemsSource == false)
            {
                for (int i = 0; i < 100; i++)
                {
                    //radTreeView.Items.Add(i.ToString() + ".ABC");
                   // radTreeView_.Items.Add(i.ToString() + ".ABC");
                }
            }
            else
            {
                for (int i = 0; i < 50; i++)
                {
                    // int j = i / 3;
                    source.Add(i.ToString() + ".AAAAABBBBBCCCCC");
                }
                //radTreeView.ItemsSource = source;
            }

            //radTreeView_.ItemClick += RadTreeView2_ItemClick;
            //radTreeView2.ItemClick += RadTreeView2_ItemClick;
        }

        private void RadTreeView2_ItemClick(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            RadTreeViewItem item = e.OriginalSource as RadTreeViewItem;
            if (item.Items.Count != 0) //is not leaf
                item.IsExpanded = !item.IsExpanded;
        }

        private void UpdateButton_Click1(object sender, RoutedEventArgs e)
        {
            //radTreeView.Items.Add("aaaaaa");
            /*RadTreeViewItem target = radTreeView.ContainerFromItemRecursive(radTreeView.Items[0]);
            RadTreeViewItem source = radTreeView.ContainerFromItemRecursive(radTreeView.Items[1]);
            radTreeView.Items.Remove(source);
            target.Items.Add(source);*/

        }
        private void UpdateButton_Click2(object sender, RoutedEventArgs e)
        {
            RadTreeViewItem target = treeViewItem1.Items[1] as RadTreeViewItem;
            treeViewItem1.Items.Remove(target);
            treeViewItem2.Items.Add(target);
            /*if (bUseItemsSource == false)
            {
                radTreeView.Items[1]= "new.ABC";
            }
            else
            {
                source.Add("new.AAAA");
                radTreeView.ItemsSource = null;
                radTreeView.ItemsSource = source;
            }*/
            /*
            RadTreeViewItem target = radTreeView_.Items[0] as RadTreeViewItem;
            RadTreeViewItem source = radTreeView_.Items[1] as RadTreeViewItem;
            radTreeView_.Items.Remove(source);
            target.Items.Add(source);*/
        }
    }
}
