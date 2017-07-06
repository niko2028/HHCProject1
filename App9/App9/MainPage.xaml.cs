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
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.Start,
                Text = "Ingresar",
                TextColor = Color.White,
                BackgroundColor = Color.Transparent,
                BorderColor = Color.White,
                FontSize = 20


            };
            var btnUsuarioNuevo = new Button
            {
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.End,
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
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.Children.Add(btnUsuarioRegistrado, 0, 0);
            grid.Children.Add(btnUsuarioNuevo, 1, 0);
            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.End,
                    Padding = 10,
                    Spacing = 20,
                    Children = { grid }
                }
            };
        }
    }
}

