using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamlFeatures
{
    public partial class DataTemplatePage : ContentPage
    {
        public DataTemplatePage()
        {
            InitializeComponent();

            var peaple = new List<Person>
            {
                new Person("Daigo", 38, "Male"),
                new Person("北川景子", 29, "Female"),
                new Person("KABA.ちゃん", 47, "GSM")
            };

            this.BindingContext = peaple;
        }
    }
}
