using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SombreroSelec : ContentPage
    {
        public SombreroSelec()
        {
            InitializeComponent();
            btnsombrero.Clicked += Btnsombrero_Clicked;
        }

        private void Btnsombrero_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PreguntasSombrero());
        }
    }
}