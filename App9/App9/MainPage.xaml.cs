using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App9
{
    public class MyContentPage : ContentPage
    {
        public MyContentPage()
        {
            Padding = new Thickness(30);
            BackgroundColor = Color.DarkSlateGray;
            BackgroundImage = "fondohp.png";    
            
            var white = new Label
            {
                Text = "Hogwarts: House Cup",
                BackgroundColor = Color.Transparent,
                TextColor = Color.WhiteSmoke,
                FontAttributes = FontAttributes.Italic,         
                FontSize = 25,
                
            };
            var btnUsuarioRegistrado = new Button
            {
                VerticalOptions = LayoutOptions.EndAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Text = "Ingresar",             
                TextColor = Color.White,
                BackgroundColor = Color.Transparent,
                BorderColor = Color.White,
                FontSize = 20
                
                
            };
            var btnUsuarioNuevo = new Button
            {
                VerticalOptions = LayoutOptions.EndAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Text = "Registrarse",
                TextColor = Color.White,
                BackgroundColor = Color.Transparent,
                BorderColor = Color.White,
                FontSize = 20
            };
            btnUsuarioNuevo.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new PageRegistro());

            };
            btnUsuarioRegistrado.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new PageIngreso());

            };
            
            Content = new StackLayout
            {
                Padding = 20,
                Spacing = 40,
                Children = { white, btnUsuarioRegistrado, btnUsuarioNuevo}
            };
        }
    }
}

