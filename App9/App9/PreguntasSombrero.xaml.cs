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
	public partial class PreguntasSombrero : ContentPage
	{
		public PreguntasSombrero ()
		{
			InitializeComponent ();
            BackgroundColor = Color.DarkGray;
            var pergamino = new Image
            {
                Source = "https://1.bp.blogspot.com/-D9Y4_GtO1_s/UkEBVf0z4QI/AAAAAAAA3dw/cpo9aIHiAAI/s1600/pergamino,banners,clipart,scrap,png,vintage+(9).png",
                Scale = 1.7,

            };
            var pregunta = new Label
            {
                Text = "Que Casa Preferis?",
                Margin = 30,
                HorizontalOptions = LayoutOptions.Center
            };
            var botonGry = new Button
            {
                Text = "Gryffindor"
            };
            var imagGry = new Image
            {
                Source = "sombrero.jpg"
            };
            botonGry.Clicked += BotonGry_Clicked;
            var gridPregun = new Grid();
            gridPregun.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridPregun.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            gridPregun.Children.Add(pergamino , 0, 0);
            gridPregun.Children.Add(pregunta, 0, 0);
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.Center,
                Padding = 20,
                Spacing = 20,
                Children = {gridPregun,botonGry}
            };
        }

        private void BotonGry_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SalaComun());
        }
    }
}