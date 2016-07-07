using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XF_SalesDashboard.Models;
using XF_SalesDashboard.ViewModels;

namespace XF_SalesDashboard.WPF.ViewModels
{
    public class MainWindowViewModel : AreaPageViewModel
    {

        public MainWindowViewModel()
        {
            SingletonSalesClass.Instance.PropertyChanged += Instance_PropertyChanged;
            ClearFilterCommand = new Prism.Commands.DelegateCommand(() =>
            {
                Init2();
            });

            Init2();
            System.Diagnostics.Debug.WriteLine("【Constructor】AreaPageViewModel");
        }

        public void Init2()
        {
            this.SalesData = SingletonSalesClass.Instance.GetSales();
            this.CategoryData = SingletonSalesClass.Instance.GetSalesbyCategories();
            this.SegmentData = SingletonSalesClass.Instance.GetSalesbySegments();
            this.AreaData = SingletonSalesClass.Instance.GetAreas();
        }

        private void Instance_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(SingletonSalesClass.SalesData))
            {
                this.CategoryData = SingletonSalesClass.Instance.GetSalesbyCategories();
                this.SegmentData = SingletonSalesClass.Instance.GetSalesbySegments();
                this.AreaData = SingletonSalesClass.Instance.GetAreas();
            }
        }

        //private List<SummaryModel> _areaData;
        //public List<SummaryModel> AreaData
        //{
        //    get { return _areaData; }
        //    set
        //    {
        //        if (_areaData != value)
        //        {
        //            _areaData = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}
        
        
        //private SummaryModel selectedArea;

        //public SummaryModel SelectedArea
        //{
        //    get { return selectedArea; }
        //    set
        //    {
        //        selectedArea = value;
        //        OnPropertyChanged();
        //        if (value != null)
        //        {
        //            this.SalesData = SingletonSalesClass.Instance.GetSales(value.Item);
        //            this.CategoryData = SingletonSalesClass.Instance.GetSalesbyCategories(value.Item);
        //            this.SegmentData = SingletonSalesClass.Instance.GetSalesbySegments(value.Item);

        //        }
        //    }
        //}

        //private SummaryModel selectedStore;

        //public SummaryModel SelectedStore
        //{
        //    get { return selectedStore; }
        //    set
        //    {
        //        selectedStore = value;
        //        OnPropertyChanged();
        //        if (value != null && this.SelectedArea != null)
        //        {
        //            this.CategoryData = SingletonSalesClass.Instance.GetSalesbyCategories(this.SelectedArea.Item, value.Item);
        //            this.SegmentData = SingletonSalesClass.Instance.GetSalesbySegments(this.SelectedArea.Item, value.Item);
        //        }
        //    }
        //}

        public Prism.Commands.DelegateCommand ClearFilterCommand { get; private set; }

    }
}

