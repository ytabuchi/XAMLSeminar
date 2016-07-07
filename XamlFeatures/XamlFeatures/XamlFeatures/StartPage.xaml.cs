using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamlFeatures
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();

            PageNavigationManager.Instance.Init(this.Navigation);
        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            // 
            switch (((Button)sender).Text)
            {
                case "ResourcesPage":
                    await Navigation.PushAsync(new ResourcesPage());
                    break;
                case "StylesPage":
                    await Navigation.PushAsync(new StylesPage());
                    break;
                case "TriggersPage":
                    await Navigation.PushAsync(new TriggersPage());
                    break;
                case "BehaviorsPage":
                    await Navigation.PushAsync(new BehaviorsPage());
                    break;
                case "ValueConverterPage":
                    await Navigation.PushAsync(new ValueConverterPage());
                    break;
                case "DataTemplatePage":
                    await Navigation.PushAsync(new DataTemplatePage());
                    break;
                case "DataBindingPage":
                    await Navigation.PushAsync(new DataBindingPage());
                    break;
                default:
                    break;
            }
        }
    }
}
