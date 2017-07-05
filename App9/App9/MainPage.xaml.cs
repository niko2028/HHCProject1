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
            Title = "Hogwarts: The Cup";
            Padding = new Thickness(30);
            BackgroundColor = Color.DarkSlateGray;
            BackgroundImage = "fondohp.png";    
            
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
                Children = { btnUsuarioRegistrado, btnUsuarioNuevo}
            };
        }
    }
}

