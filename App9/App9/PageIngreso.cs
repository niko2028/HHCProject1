using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App9
{
    public class PageIngreso : ContentPage
    {

        public PageIngreso()
        {
            Padding = new Thickness(30);
            BackgroundColor = Color.DarkSlateGray;
            BackgroundImage = "damagorda";
            var white = new Label
            {
                Text = "Ingresar",
                BackgroundColor = Color.Transparent,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Italic,
                FontSize = 20,
            };
            var btnIngresar = new Button
            {
                Text = "Ingresar",
                TextColor = Color.White,
                BackgroundColor = Color.Transparent,
                VerticalOptions = LayoutOptions.EndAndExpand,
                BorderColor = Color.White,
                FontSize = 25

            };
            var txtboxMail = new Entry
            {
                VerticalOptions = LayoutOptions.EndAndExpand,
                Placeholder = "Ingrese Mail",
                PlaceholderColor = Color.White,
                BackgroundColor = Color.Transparent,
                TextColor = Color.White,
                FontAttributes = FontAttributes.Italic,
                FontSize = 25,
            };
            var txtboxClave = new Entry
            {
                VerticalOptions = LayoutOptions.EndAndExpand,
                IsPassword = true,
                Placeholder = "Ingrese Contraseña",
                PlaceholderColor = Color.White,
                BackgroundColor = Color.Transparent,
                TextColor = Color.White,
                FontAttributes = FontAttributes.Italic,
                FontSize = 25,
            };
           /* var imagen = new Image { Aspect = Aspect.AspectFit };
            {
                imagen.Source = "damagorda.jpg";
                
            }*/
            btnIngresar.Clicked += (sender, e) =>
            {
                DisplayAlert("Message", "Bienvenido", "OK");
                Navigation.PushAsync(new PagePreguntas());
                /*Usuario usuarioPrueba = new Usuario
                {
                    Mail = txtboxMail.Text,
                    Clave = txtboxClave.Text
                };
                using (var datos = new DataAcces())
                {
                    try
                    {
                        datos.GetUsuario(txtboxMail.Text);
                        datos.GetUsuario(txtboxClave.Text);
                    }
                    catch
                    {
                        throw;
                    }
                }
                DisplayAlert("Message", "Bienvenido", "OK");
                Navigation.PushAsync(new PagePreguntas());
                */
            };
           /* var listview = new ListView();
            listview.ItemsSource = new string[]
            {
                "Primero",
                "segundo",
                "Tercero",
                "Cuarto",
                "Quinto",
                "Sexto"
            };*/
            Content = new StackLayout
            {
                
                Padding = 20,
                Spacing = 20,
                Children = { white, txtboxMail, txtboxClave, btnIngresar, }
            };
        }
    }
}