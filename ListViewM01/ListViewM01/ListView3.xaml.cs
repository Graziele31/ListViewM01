using ListViewM01.modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewM01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView3 : ContentPage
    {
        public ListView3()
        {
            InitializeComponent();
            List<Produto> listaProduto = new List<Produto>
            {
                new Produto
                {
                    img = "https://a-static.mlcdn.com.br/618x463/cafeteira-eletrica-philco-ph30-thermo-30-xicaras-aco/magazineluiza/023514500/f9b73ea2fb3f2204dc1f71f20e2335fe.jpg",
                    nome = "Cafeteira Wallita",
                    valor = 299.90
                },
                new Produto
                {
                    img = "https://imagens.trocafone.com/images/phones/dt-moto-g6-preto-frete.png",
                    nome = "Celular Moto G6",
                    valor = 99.90
                },
                  new Produto
                {
                    img = "https://staticmobly.akamaized.net/p/Mobly-SofC3A1-2-Lugares-RetrC3A1til-Lubeck-Linho-Cinza-7465-966797-1-zoom.jpg",
                    nome = "Sofá",
                    valor = 800.00
                },
            };

            listview1.ItemsSource = listaProduto;
        }

        private void listView1_Itemselected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}