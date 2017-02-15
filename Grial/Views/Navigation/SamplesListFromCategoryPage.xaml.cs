using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UXDivers.Artina.Grial.Dataprovider;
using UXDivers.Artina.Grial.Views.Navigation;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
	public partial class SamplesListFromCategoryPage : ContentPage
	{
		private bool _processingSelection = false;
        

        public SamplesListFromCategoryPage ( SampleCategory sampleCategory )
		{
			InitializeComponent ();
            
            BindingContext = new AuthorizationLineViewModel(sampleCategory.Name);

        }
        

       

		public static async Task NavigateToCategory(SampleCategory sampleCategory, INavigation navigation){
			await navigation.PushAsync( new TabbedPageRLC( sampleCategory ) );
		}
	}
}