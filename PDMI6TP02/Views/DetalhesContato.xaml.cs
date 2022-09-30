using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDMI6TP02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesContato : ContentPage
    {
        public DetalhesContato()
        {
            InitializeComponent();
        }

        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }

    }
}