using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RadComboBoxTest
{
    public sealed partial class App : Application
    {
        public App()
        {
            Console.WriteLine("Loading done ");

            this.InitializeComponent();

            Application.Current.Host.Settings.EnableOptimizationWhereCollapsedControlsAreNotLoaded = true;
            //Telerik.Windows.Controls.Animation.AnimationManager.IsGlobalAnimationEnabled = false;

            Console.WriteLine("Loading done 1");
            // Enter construction logic here...

            //var mainPage = new MainPage();
            //var mainPage = new TestRadComboBox();
            //var mainPage = new TestRadDropDownButton();
            //var mainPage = new TestDataGrid();
            //var mainPage = new TestRadTreeView();
            //var mainPage = new TestRadTreeListView();
            //var mainPage = new TestRadListBox();
            var mainPage = new TestSISEControls();

            Window.Current.Content = mainPage;
        }
    }
}
