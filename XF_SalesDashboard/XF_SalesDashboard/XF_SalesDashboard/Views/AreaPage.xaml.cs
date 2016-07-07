using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XF_SalesDashboard.Views
{
    public partial class AreaPage : ContentPage
    {
        ViewModels.AreaPageViewModel vm = new ViewModels.AreaPageViewModel();
        public AreaPage()
        {
            InitializeComponent();
            vm.SelectedArea = new Models.SummaryModel
            {
                Item = "東",
                Value = 6d
            };
            this.BindingContext = vm;
        }

    }
}
