using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlFeatures
{
    public class MinLengthToDisableBehavior : Behavior<Entry>
    {
        public View OtherView { get; set; }
        public int MinLength { get; set; } = 4;

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            // XAMLでOtherViewにIsEnabled可能なコントロール
            if (OtherView != null)
                OtherView.IsEnabled = e.NewTextValue?.Length >= MinLength;

            bool isValid = e.NewTextValue?.Length >= MinLength;
            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
        }
    }
}
