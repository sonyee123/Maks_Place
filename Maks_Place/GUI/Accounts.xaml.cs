using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maks_Place.GUI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Accounts : ContentPage
	{
		public Accounts ()
		{
			InitializeComponent();
		}
        async void ButtonSignUp_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GUI.SignUp());
        }
    }
}