using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GamePerguntasERespostas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            string texto = enResposta.Text;
            if (texto.ToUpper() == "CONSTANTINO")
            {
                Navigation.PushAsync(new Page1());
            }
            else
            {
                DisplayAlert("Wesley fala:", "Você errou!", "OK");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}