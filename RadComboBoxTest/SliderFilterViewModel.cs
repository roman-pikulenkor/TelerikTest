using System.ComponentModel;
using Telerik.Windows.Data;
using System;

namespace RadComboBoxTest
{
    /// <summary>SliderFilterViewModel</summary>
    public class SliderFilterViewModel : INotifyPropertyChanged
    {
        #region Public Events -------------------------------------------------------------------

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion Public Events -------------------------------------------------------------------
        #region Private ReadOnly Members --------------------------------------------------------

        private readonly string dataMemberName;
        private readonly FilterDescriptorCollection targetCollection;
        private readonly double min;
        private readonly double max;

        private readonly CompositeFilterDescriptor compositeFilter;
        private readonly FilterDescriptor startFilter;
        private readonly FilterDescriptor endFilter;
        #endregion Private ReadOnly Members --------------------------------------------------------
        #region Public Properties ---------------------------------------------------------------

        public bool IsActive
        {
            get
            {
                if (this.compositeFilter != null)
                {
                    return this.targetCollection.Contains(this.compositeFilter);
                }

                return false;
            }
        }

        public double Start
        {
            get { return Convert.ToDouble(this.startFilter.Value); }
            set
            {
                if ((double)this.startFilter.Value != value)
                {
                    this.EnsureFilterIsAddedInTargetCollection();
                    this.startFilter.Value = value;
                    this.OnPropertyChanged("Start");
                    this.OnPropertyChanged("IsActive");
                }
            }
        }

        public double End
        {
            get { return Convert.ToDouble(this.endFilter.Value); }
            set
            {
                if ((double)this.endFilter.Value != value)
                {
                    this.EnsureFilterIsAddedInTargetCollection();
                    this.endFilter.Value = value;
                    this.OnPropertyChanged("End");
                    this.OnPropertyChanged("IsActive");
                }
            }
        }
        #endregion Public Properties ---------------------------------------------------------------
        #region Private Methods -----------------------------------------------------------------

        private void EnsureFilterIsAddedInTargetCollection()
        {
            if (this.compositeFilter != null
                && !this.targetCollection.Contains(this.compositeFilter))
            {
                this.targetCollection.Add(this.compositeFilter);
            }
        }
        #endregion Private Methods -----------------------------------------------------------------
        #region Constructors --------------------------------------------------------------------

        public SliderFilterViewModel(string dataMemberName
            , FilterDescriptorCollection targetCollection
            , double min
            , double max)
        {
            this.dataMemberName = dataMemberName;
            this.targetCollection = targetCollection;
            this.min = min;
            this.max = max;

            this.compositeFilter = new CompositeFilterDescriptor();

            this.startFilter = new FilterDescriptor(this.dataMemberName
                , FilterOperator.IsGreaterThanOrEqualTo
                , this.min);
            this.compositeFilter.FilterDescriptors.Add(this.startFilter);

            this.endFilter = new FilterDescriptor(this.dataMemberName
                , FilterOperator.IsLessThanOrEqualTo
                , this.max);
            this.compositeFilter.FilterDescriptors.Add(this.endFilter);
        }

        public SliderFilterViewModel(string dataMemberName
            , FilterDescriptorCollection targetCollection
            , int min
            , int max)
        {
            this.dataMemberName = dataMemberName;
            this.targetCollection = targetCollection;
            this.min = min;
            this.max = max;

            this.compositeFilter = new CompositeFilterDescriptor();

            this.startFilter = new FilterDescriptor(this.dataMemberName
                , FilterOperator.IsGreaterThanOrEqualTo
                , this.min);
            this.compositeFilter.FilterDescriptors.Add(this.startFilter);

            this.endFilter = new FilterDescriptor(this.dataMemberName
                , FilterOperator.IsLessThanOrEqualTo
                , this.max);
            this.compositeFilter.FilterDescriptors.Add(this.endFilter);
        }
        #endregion Constructors --------------------------------------------------------------------
        #region Public Methods ------------------------------------------------------------------

        public void Clear()
        {
            if (this.compositeFilter != null)
            {
                this.targetCollection.Remove(this.compositeFilter);
                this.startFilter.Value = this.min;
                this.OnPropertyChanged("Start");
                this.endFilter.Value = this.max;
                this.OnPropertyChanged("End");
            }

            this.OnPropertyChanged("IsActive");
        }
        #endregion Public Methods ------------------------------------------------------------------
        #region On Property Changed -------------------------------------------------------------

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if (null != this.PropertyChanged)
            {
                this.PropertyChanged(this, args);
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        #endregion On Property Changed -------------------------------------------------------------
    }
}
