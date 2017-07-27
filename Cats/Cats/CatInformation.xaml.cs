using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cats
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CatInformation : ContentPage
	{
		public CatInformation ()
		{
			InitializeComponent ();
		}

        void OnButtonClicked(object sender, EventArgs args)
        {
            Device.OpenUri(new Uri("http://www.spca.com/?page_id=4882&lang=en"));
        }
    }
}