using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace RadComboBoxTest
{
    public partial class ChildWindowPopupRadGrid : ChildWindow
    {
        List<ItemBatchInternal> lstItems = new List<ItemBatchInternal>();
        public ChildWindowPopupRadGrid()
        {
            InitializeComponent();

            theRadGrid.Loaded += TheRadGrid_Loaded;

            generateItems();
        }

        private void generateItems()
        {
            int rows = 3;
            for(int i = 0; i < rows; i++)
            {
                ItemBatchInternal item = new ItemBatchInternal();
                item.CastingNumber = $"{i + 1}Cast";
                lstItems.Add(item);
            }

            theRadGrid.ItemsSource = lstItems;
        }

        private void TheRadGrid_Loaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"desiredHeight={theRadGrid.DesiredSize.Height}, renderedHeight={theRadGrid.RenderSize.Height}, actualHeight={theRadGrid.ActualHeight}");
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void CreateGrid()
        {
            for (int i = 0; i < 5; i++)
            {
                theGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            int rowsCount = 8;
            for (int i = 0; i < rowsCount; i++)
            {
                theGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            }

            for (int rowIndx = 0; rowIndx < theGrid.RowDefinitions.Count; rowIndx++)
            {
                var panel = new StackPanel() { Margin = new Thickness(10) };
                panel.Children.Add(new TextBox() { Text = rowIndx.ToString(), Height = 20 });
                Grid.SetRow(panel, rowIndx);
                theGrid.Children.Add(panel);
            }

            //theGrid.Measure(new Size(1000, 1000));
            //this.Height = theGrid.DesiredSize.Height;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //CreateGrid();

        }
    }
}

