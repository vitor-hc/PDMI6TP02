using PDMI6TP02.Models;
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
    public partial class CadastroProduto : ContentPage
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private async void btnSave(object sender, EventArgs e)
        {
            var id = txtId.Text;
            var descricao = txtDescricao.Text;
            var categoria = txtCategoria.Text;
            var quant = txtQuantidade.Text;
            var preco = txtPreco.Text;



            Produto produto = new Produto
                {
                    Id = Convert.ToInt32(id),
                    Descricao = descricao,
                    Categoria = categoria,
                    Quantidade = Convert.ToInt32(quant),
                    Preco = Convert.ToDecimal(preco),
                };

                DetalhesProduto detalhesProduto = new DetalhesProduto();
                detalhesProduto.BindingContext = produto;

                await Navigation.PushAsync(detalhesProduto);
            
        }
    }
}