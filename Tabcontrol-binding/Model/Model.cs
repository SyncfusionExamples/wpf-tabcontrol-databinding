using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabcontrol_binding
{
    public class Model : NotificationObject
    {
        private string header;
        public string Header
        {
            get { return header; }
            set
            {
                header = value;
                this.RaisePropertyChanged("Header");
            }
        }

        private string content;
        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                this.RaisePropertyChanged("Content");
            }
        }

        private string image;
        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                this.RaisePropertyChanged("Image");
            }
        }

        private ImageAlignment imageAlignment = ImageAlignment.LeftOfText;
        public ImageAlignment ImageAlignment
        {
            get { return imageAlignment; }
            set
            {
                imageAlignment = value;
                this.RaisePropertyChanged("ImageAlignment");
            }
        }

        public Model()
        {

        }
    }
}
