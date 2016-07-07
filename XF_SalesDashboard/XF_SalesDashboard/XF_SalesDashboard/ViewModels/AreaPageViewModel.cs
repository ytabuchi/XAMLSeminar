using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XF_SalesDashboard.Models;

namespace XF_SalesDashboard.ViewModels
{
    public class AreaPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Properties
        private List<SummaryModel> _salesData;
        public List<SummaryModel> SalesData
        {
            get { return _salesData; }
            set
            {
                if (_salesData != value)
                {
                    _salesData = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<SummaryModel> _categoryData;
        public List<SummaryModel> CategoryData
        {
            get { return _categoryData; }
            set
            {
                if (_categoryData != value)
                {
                    _categoryData = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<SummaryModel> _segmentData;
        public List<SummaryModel> SegmentData
        {
            get { return _segmentData; }
            set
            {
                if (_segmentData != value)
                {
                    _segmentData = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<SummaryModel> _areaData;
        public List<SummaryModel> AreaData
        {
            get { return _areaData; }
            set
            {
                if (_areaData != value)
                {
                    _areaData = value;
                    OnPropertyChanged();
                }
            }
        }

        private SummaryModel selectedArea;

        public SummaryModel SelectedArea
        {
            get { return selectedArea; }
            set
            {
                selectedArea = value;
                OnPropertyChanged();
                if (value != null)
                {
                    this.SalesData = SingletonSalesClass.Instance.GetSales(value.Item);
                    this.CategoryData = SingletonSalesClass.Instance.GetSalesbyCategories(value.Item);
                    this.SegmentData = SingletonSalesClass.Instance.GetSalesbySegments(value.Item);

                }
            }
        }

        private SummaryModel selectedStore;

        public SummaryModel SelectedStore
        {
            get { return selectedStore; }
            set
            {
                selectedStore = value;
                OnPropertyChanged();
                if (value != null && this.SelectedArea != null)
                {
                    this.CategoryData = SingletonSalesClass.Instance.GetSalesbyCategories(this.SelectedArea.Item, value.Item);
                    this.SegmentData = SingletonSalesClass.Instance.GetSalesbySegments(this.SelectedArea.Item, value.Item);
                }
            }
        }
        #endregion

        /// <summary>
        /// コンストラクター
        /// </summary>
        public AreaPageViewModel()
        {
            // Initialize
            Init();
            System.Diagnostics.Debug.WriteLine("【Constructor】AreaPageViewModel");
        }


        /// <summary>
        /// 初期化メソッド
        /// </summary>
        public void Init()
        {
            SingletonSalesClass.Instance.PropertyChanged += Instance_PropertyChanged;

            this.SalesData = SingletonSalesClass.Instance.GetSales();
            this.CategoryData = SingletonSalesClass.Instance.GetSalesbyCategories();
            this.SegmentData = SingletonSalesClass.Instance.GetSalesbySegments();
        }








        private void Instance_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(SingletonSalesClass.SalesData))
            {
                this.SalesData = SingletonSalesClass.Instance.GetSales();
                this.CategoryData = SingletonSalesClass.Instance.GetSalesbyCategories();
                this.SegmentData = SingletonSalesClass.Instance.GetSalesbySegments();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
