using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlFeatures
{
    public class PersonDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MaleTemplate { get; set; }
        public DataTemplate FemaleTemplate { get; set; }
        public DataTemplate GsmTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (((Person)item).Gender)
            {
                case "Male":
                    return MaleTemplate;
                case "Female":
                    return FemaleTemplate;
                default:
                    return GsmTemplate;
            }

            //return ((Person)item).Gender == "Male" ? MaleTemplate : FemaleTemplate;
        }
    }
}
