using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamlFeatures
{
    public partial class DataBindingPage : ContentPage
    {
        public DataBindingPage()
        {
            InitializeComponent();
            this.BindingContext = new DataBindingPageViewModel();
        }
    }
}
