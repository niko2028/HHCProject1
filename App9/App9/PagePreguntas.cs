using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App9
{
    public class PagePreguntas : ContentPage
    {
        public PagePreguntas()
        {
            Padding = new Thickness(30);
            BackgroundColor = Color.DarkSlateGray;
            var white = new Label
            {
                Text = "Que escoba utilizo harry \n potter en Harry Potter y \n la orden del fenix",
                BackgroundColor = Color.Transparent,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Italic,
                FontSize = 20,

            };
            var btnCorrecto = new Button
            {
                Text = "Saeta de Fuego",
                TextColor = Color.White,
                BackgroundColor = Color.CadetBlue,
                BorderColor = Color.White,
                FontSize = 20

            };
            var btnRespuesta = new Button
            {
                Text = "Nimbus 2000",
                TextColor = Color.White,
                BackgroundColor = Color.CadetBlue,
                BorderColor = Color.White,
                FontSize = 20

            };
            var btnRespuesta3 = new Button
            {
                Text = "Nimbus 2001",
                TextColor = Color.White,
                BackgroundColor = Color.CadetBlue,
                BorderColor = Color.White,
                FontSize = 20

            };
            var btnRespuesta2 = new Button
            {
                Text = "Barredora",
                TextColor = Color.White,
                BackgroundColor = Color.CadetBlue,
                BorderColor = Color.White,
                FontSize = 20

            };
            btnRespuesta.Clicked += (sender, e) =>
            {
                btnRespuesta.BackgroundColor = Color.Red;
                btnRespuesta2.BackgroundColor = Color.Red;
                btnRespuesta3.BackgroundColor = Color.Red;
                btnCorrecto.BackgroundColor = Color.Green;
                
            };
            btnRespuesta2.Clicked += (sender, e) =>
            {

                btnRespuesta.BackgroundColor = Color.Red;
                btnRespuesta2.BackgroundColor = Color.Red;
                btnRespuesta3.BackgroundColor = Color.Red;
                btnCorrecto.BackgroundColor = Color.Green;
            };
            btnRespuesta3.Clicked += (sender, e) =>
            {
                btnRespuesta.BackgroundColor = Color.Red;
                btnRespuesta2.BackgroundColor = Color.Red;
                btnRespuesta3.BackgroundColor = Color.Red;
                btnCorrecto.BackgroundColor = Color.Green;
            };
            btnCorrecto.Clicked += (sender, e) =>
            {
                btnCorrecto.BackgroundColor = Color.Green;
               // DisplayAlert("Message", "Correcto", "OK");
                Navigation.PushModalAsync(new SalaComun());

            };
            var webImage = new Image { Aspect = Aspect.AspectFit };
            {
               // webImage.Source = ImageSource.FromUri(new Uri("https://xamarin.com/content/images/pages/forms/example-app.png"));
            }
            var correcto = new Label
            {
                Text = "",
                TextColor = Color.White,
                BackgroundColor = Color.Green
            };
            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Padding = 30,
                    Spacing = 20,
                    Children = { white, webImage, btnRespuesta2, btnRespuesta, btnCorrecto, btnRespuesta3 }
                }
            };          
        }
    }
}