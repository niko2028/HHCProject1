using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace App9
{
    public class PageRegistro : ContentPage
    {
        public PageRegistro()
        {
            Padding = new Thickness(30);
            BackgroundColor = Color.DarkSlateGray;
            BackgroundImage = "registrohp.jpg";
            var white = new Label
            {
                Text = "Registro",
                BackgroundColor = Color.Transparent,
                TextColor = Color.White,
                FontAttributes = FontAttributes.Italic,
                FontSize = 20,
            };
            var btnUsuario = new Button
            {
                Text = "Aceptar",
                TextColor = Color.White,
                BackgroundColor = Color.Transparent,
                BorderColor = Color.White,
                FontSize = 25

            };

            var txtboxMail = new Entry
            {
                Placeholder = "Ingrese Mail",
                PlaceholderColor = Color.White,
                BackgroundColor = Color.Transparent,
                TextColor = Color.White,
                FontAttributes = FontAttributes.Italic,
                FontSize = 25,
            };
            var txtboxClave = new Entry
            {
                IsPassword = true,
                Placeholder = "Ingrese Contraseña",
                PlaceholderColor = Color.White,
                BackgroundColor = Color.Transparent,
                TextColor = Color.White,
                FontAttributes = FontAttributes.Italic,
                FontSize = 25,
            };
            var txtboxReclave = new Entry
            {
                IsPassword = true,
                Placeholder = "Reingrese Contraseña",
                PlaceholderColor = Color.White,
                BackgroundColor = Color.Transparent,
                TextColor = Color.White,
                FontAttributes = FontAttributes.Italic,
                FontSize = 25,
            };
            btnUsuario.Clicked += (sender, e) =>
            {
                DisplayAlert("Message", "Registro Exitoso", "OK");
                Navigation.PushAsync(new PagePreguntas());

            };
            Content = new StackLayout
            {
                Padding = 20,
                Spacing = 20,
                Children = { white, txtboxMail, txtboxClave, txtboxReclave, btnUsuario }
            };
        }
      /*  private async void btnUsuario_Clicked(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {

            };
            using (var datos = new DataAcces())
            {
                datos.InsertUsuario(usuario);

                DisplayAlert("Message", "Registro Exitoso", "OK");
                // Navigation.PushAsync(new MyContentPage());
                Navigation.PushAsync(new PagePreguntas());
            }
        }*/
    }
}