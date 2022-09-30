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
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
        }
        async void BtnEstiloPadrao(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloPadrao());
        }
        async void BtnEstiloDinamico(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloDinamico());
        }
        async void BtnTrigger(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TriggersView());
        }
        async void BtnListViewSimples(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewSimples());
        }
        async void BtnHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
        async void BtnProduto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroProduto());
        }

    }
}