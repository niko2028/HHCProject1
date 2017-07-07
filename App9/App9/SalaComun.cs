using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App9
{
    public class SalaComun : TabbedPage
    {

        public SalaComun()
        {
            this.Title = "Sala Comun";
            BarBackgroundColor = Color.DarkGreen;

            var imagenGry = new Image
            {
                Source = "gryffindor.png",
            };
            var imagenSly = new Image
            {
                Source = "slytherin.png",
            };
            var imagenRav = new Image
            {
                Source = "ravenclaw.png"
            };
            var Tapgesto = new TapGestureRecognizer();
            var imagenHuf = new Image
            {
                Source = "hufflepuff.png"

            };
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                BarBackgroundColor = Color.DarkRed;
            };
            imagenGry.GestureRecognizers.Add(tapGestureRecognizer);

            var tapGestureRecognizerRav = new TapGestureRecognizer();
            tapGestureRecognizerRav.Tapped += (s, e) => {
                BarBackgroundColor = Color.DodgerBlue;
            };
            imagenRav.GestureRecognizers.Add(tapGestureRecognizerRav);

            var tapGestureRecognizerHuf = new TapGestureRecognizer();
            tapGestureRecognizerHuf.Tapped += (s, e) => {
                BarBackgroundColor = Color.Goldenrod;
            };
            imagenHuf.GestureRecognizers.Add(tapGestureRecognizerHuf);

            var tapGestureRecognizerSly = new TapGestureRecognizer();
            tapGestureRecognizerSly.Tapped += (s, e) => {
                BarBackgroundColor = Color.DarkGreen;

            };
            imagenSly.GestureRecognizers.Add(tapGestureRecognizerSly);

            var btnPreguntas = new Button
            {
                Text = "Preguntas",
                FontSize = 15,
                BackgroundColor = Color.Transparent,
            };
            var btnDuelo = new Button
            {
                Text = "Club de duelos",
                FontSize = 15,
                BackgroundColor = Color.Transparent,
            };

            var gridSalaComun = new Grid();
            gridSalaComun.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridSalaComun.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            gridSalaComun.Children.Add(btnPreguntas, 0, 0);
            gridSalaComun.Children.Add(btnDuelo, 1, 0);

            this.Children.Add(new ContentPage
            {
                Title = "Casa",
                BackgroundImage = "slytherinmain.jpg",
                Content = new StackLayout
                {

                    Spacing = 1,
                    VerticalOptions = LayoutOptions.End,
                    Children = { gridSalaComun },
                }
            }
            );
            this.Children.Add(new ContentPage
            {
                Title = "Tabla Casas",
                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        BackgroundColor = Color.DarkGreen,
                        Spacing = 10,
                        Children = { imagenSly, imagenRav, imagenGry, imagenHuf },

                    }
                }
            });
            btnPreguntas.Clicked += BtnPreguntas_Clicked;
            var imagenGranComedor = new Image
            {
                Source = "comedorgryf.jpg",
            };
            var lblCampeones = new Label
            {
                Text = "Campeones del mes",
                TextColor = Color.Goldenrod,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 20,
                BackgroundColor = Color.Transparent
            };
            this.Children.Add(new ContentPage
            {  
                Title = "Gran Comedor",
                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Children = {imagenGranComedor, lblCampeones },
                    }
                }
                });

            btnPreguntas.Clicked += BtnPreguntas_Clicked;
        }
        private void BtnPreguntas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PagePreguntas());
        }
    }
}