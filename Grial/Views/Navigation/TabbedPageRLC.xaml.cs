using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.Navigation
{
    public partial class TabbedPageRLC : TabbedPage
    {
        public TabbedPageRLC()
        {
            InitializeComponent();
        }

        public string CounterPart { get; set; }


        public TabbedPageRLC(SampleCategory counterpart)
        {
            CounterPart = counterpart.Name;
            Children.Add(new SamplesListFromCategoryPage(counterpart));
            InitializeComponent();
            BindingContext = this;
        }

        public static async Task NavigateToCategory(SampleCategory sampleCategory, INavigation navigation)
        {
           
            await navigation.PushAsync(new TabbedPageRLC(sampleCategory));
        }

        public string Title
        {
            get
            {
                return CounterPart;
            }
        }
    }
}
