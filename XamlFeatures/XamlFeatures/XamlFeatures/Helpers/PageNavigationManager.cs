using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlFeatures
{
    public class PageNavigationManager
    {
        public static PageNavigationManager Instance { get; } = new PageNavigationManager();

        private INavigation Navigation { get; set; }

        private Dictionary<string, Type> PageMap { get; } = new Dictionary<string, Type>();

        public void Init(INavigation navigation)
        {
            this.Navigation = navigation;
        }

        //public Task NavigateAsync(string pageName)
        //{
        //    return this.Navigation.PushAsync(Activator.CreateInstance(Type.GetType(this.PageMap[pageName])));
        //}

        public void RegisterPage(string pageName, Type pageType)
        {
            this.PageMap[pageName] = pageType;
        }
    }
}
