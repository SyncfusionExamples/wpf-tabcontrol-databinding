using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabcontrol_binding
{
    public class ViewModel : NotificationObject
    {
        private ObservableCollection<Model> tabItems;
        public ObservableCollection<Model> TabItems
        {
            get { return tabItems; }
            set
            {
                tabItems = value;
                this.RaisePropertyChanged("TabItems");
            }
        }

        private bool enableLabelEdit = true;
        public bool EnableLabelEdit
        {
            get { return enableLabelEdit; }
            set
            {
                enableLabelEdit = value;
                this.RaisePropertyChanged("EnableLabelEdit");
            }
        }

        private CloseButtonType closeButtonType=CloseButtonType.Both;
        public CloseButtonType CloseButtonType
        {
            get { return closeButtonType; }
            set
            {
                closeButtonType = value;
                this.RaisePropertyChanged("CloseButtonType");
            }
        }

        public ViewModel()
        {
            tabItems = new ObservableCollection<Model>();
            PopulateCollection();
        }

        public void PopulateCollection()
        {
            Model model1 = new Model() { Header="tab1", Content= "This is the content of first tabitem.", Image="Images/sync.png" };
            Model model2 = new Model() { Header="tab2", Content= "This is the content of second tabitem.", Image="Images/sync.png" };

            tabItems.Add(model1);
            tabItems.Add(model2);
        }
    }
}
