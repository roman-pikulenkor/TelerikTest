using System;
using System.Collections.Generic;
using System.Globalization;
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
using Telerik.Windows.Controls.GridView;

namespace RadComboBoxTest
{
    public partial class SliderFilteringControl : UserControl, IFilteringControl
    {
        #region Private Members -----------------------------------------------------------------

        private GridViewBoundColumnBase column;
        #endregion Private Members -----------------------------------------------------------------
        #region Public Properties ---------------------------------------------------------------

        /// <summary>
        /// Gets or sets a value indicating whether the filtering is active.
        /// </summary>
        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public double Minimum
        {
            get { return (double)this.slider.Minimum; }
            set { this.slider.Minimum = value; }
        }

        public double Maximum
        {
            get { return (double)this.slider.Maximum; }
            set { this.slider.Maximum = value; }
        }

        public double TickFrequency
        {
            get { return (double)this.slider.TickFrequency; }
            set { this.slider.TickFrequency = value; }
        }
        #endregion Public Properties ---------------------------------------------------------------
        #region Public Static ReadOnly Members --------------------------------------------------

        /// <summary>
        /// Identifies the <see cref="IsActive"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register(
                "IsActive",
                typeof(bool),
                typeof(SliderFilteringControl),
                new System.Windows.PropertyMetadata(false));
        #endregion Public Static ReadOnly Members --------------------------------------------------
        #region Constructors --------------------------------------------------------------------

        public SliderFilteringControl()
        {
            InitializeComponent();
        }
        #endregion Constructors --------------------------------------------------------------------
        #region Public Methods ------------------------------------------------------------------

#if OPENSILVER
        public void Prepare(GridViewColumn column)
#else
        public void Prepare(GridViewBoundColumnBase column)
#endif
        {
            if (this.column != column)
            {
#if OPENSILVER
#else
        this.column = column;
#endif
                string dataMemberName = this.column.DataMemberBinding.Path.Path;

                SliderFilterViewModel vm = new SliderFilterViewModel(dataMemberName
                    , this.column.DataControl.FilterDescriptors
                    , this.Minimum
                    , this.Maximum);

                Binding binding = new Binding("IsActive")
                {
                    Source = vm,
                    Mode = BindingMode.OneWay
                };
                this.ClearValue(SliderFilteringControl.IsActiveProperty);
                this.SetBinding(SliderFilteringControl.IsActiveProperty, binding);

                this.DataContext = vm;
            }
        }

        public void Clear()
        {
            SliderFilterViewModel vm = this.DataContext as SliderFilterViewModel;
            if (null != vm)
            {
                vm.Clear();
            }
        }
        #endregion Public Methods ------------------------------------------------------------------
        #region Button Events -------------------------------------------------------------------

        private void OnClear(object sender, RoutedEventArgs e)
        {
            Clear();
        }
        #endregion Button Events -------------------------------------------------------------------

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Console.WriteLine($"Value: {e.NewValue}");
        }

        private void slider_SelectionChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            Console.WriteLine($"Selection: {slider.SelectionStart} ~ {slider.SelectionEnd}");
        }
    }

    public class SliderTickConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is double)
            {
                double dVal = (double)value;
                return dVal.ToString("0.00");
            }
            return "";
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
