using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IntroducaoMobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void logar(object sender, EventArgs e)
        {
            if (login.Text.Equals("senai") && senha.Text.Equals("123"))
            {
                Navigation.PushAsync(new Dashboard());
            }
            else
            {
                DisplayAlert("Alerta!", "Login Inválido", "Fechar");
            }
        }
    }
}
