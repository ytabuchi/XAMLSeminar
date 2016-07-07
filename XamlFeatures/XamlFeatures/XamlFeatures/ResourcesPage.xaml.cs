using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamlFeatures
{
    public partial class ResourcesPage : ContentPage
    {
        public ResourcesPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs s)
        {
            Resources["textColor"] = Color.FromHex(entry.Text);
        }
    }
}
