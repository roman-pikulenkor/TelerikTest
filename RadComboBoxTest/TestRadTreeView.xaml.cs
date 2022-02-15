using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
    public partial class TestRadTreeView : Page
    {
        public TestRadTreeView()
        {
            this.InitializeComponent();
            this.DataContext = new RadTreeViewTestVM();
        }
    }

    #region ViewModel
    public class VMBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class RadTreeViewTestVM : VMBase
    {
        public RadTreeViewTestVM()
        {
            TreeViewItems = LoadData("TreeView", 1);
            RadTreeViewItems = LoadData("RadTreeView", 50);
        }

        private List<OrgItemLite> LoadData(string name, int nodeCount)
        {
            var ret = new List<OrgItemLite>
            {
                new OrgItemLite
                {
                    Name = $"{name} Root",
                    Childs = new List<OrgItemLite>()
                }
            };

            for (int i = 0; i < nodeCount; i++)
            {
                ret[0].Childs.Add(new OrgItemLite
                {
                    Name = $"{name} {i + 1}",
                    Childs = new List<OrgItemLite>
                    {
                        new OrgItemLite { Name = $"{name} {i + 1}.1" },
                        new OrgItemLite { Name = $"{name} {i + 1}.2" },
                    }
                });
            }

            return ret;
        }

        private OrgItemLite _selectedItem = null;

        public OrgItemLite SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (value != null && value is OrgItemLite)
                {
                    _selectedItem = value;
                }
            }
        }

        private List<OrgItemLite> _treeViewItems = new List<OrgItemLite>();

        public List<OrgItemLite> TreeViewItems
        {
            get => _treeViewItems;
            set
            {
                _treeViewItems = value;
                NotifyPropertyChanged(nameof(TreeViewItems));
            }
        }

        private List<OrgItemLite> _radTreeViewItems = new List<OrgItemLite>();

        public List<OrgItemLite> RadTreeViewItems
        {
            get => _radTreeViewItems;
            set
            {
                _radTreeViewItems = value;
                NotifyPropertyChanged(nameof(RadTreeViewItems));
            }
        }

        public ICommand LoadTreeViewCommand => new DelegateCommand(obj => TreeViewItems = LoadData("TreeView", 50));
        public ICommand LoadRadTreeViewCommand => new DelegateCommand(obj => RadTreeViewItems = LoadData("RadTreeView", 1));
    }

    #endregion

    public class OrgItemLite
    {
        public string Name { get; set; }
        public List<OrgItemLite> Childs { get; set; }
    }
}
