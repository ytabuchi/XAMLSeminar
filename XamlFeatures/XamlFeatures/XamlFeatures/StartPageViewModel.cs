using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamlFeatures
{
    // TODO: PageNavigationManager Imprementation
    class StartPageViewModel : INotifyPropertyChanged
    {
        public StartPageViewModel()
        {
            

            this.GoToCommand = new Command<string>((key) =>
            {
                System.Diagnostics.Debug.WriteLine(key);

                MessagingCenter.Send(this, "GoToPage", key);
            });
        }

        public ICommand GoToCommand { protected set; get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
