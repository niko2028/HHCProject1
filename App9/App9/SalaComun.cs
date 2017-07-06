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
            var btnGry = new Button
            {
                Text = "Gryffindor",
            };
            var btnSly = new Button
            {
                Text = "Slytherin",
            };
            var btnRav = new Button
            {
                Text = "Ravenclaw"
            };
            var btnHuf = new Button
            {
                Text = "Hufflepuff"
            };
            this.Children.Add(new ContentPage
            {
                Title = "Casas",
                BackgroundImage = "",
                Content = new ListView
                {
                    BackgroundColor = Color.Goldenrod,
                    ItemsSource = new List<Button>
                    {
                        btnGry,
                        btnHuf,
                        btnSly,
                        btnRav,
                    }
                    
                },
                
            }
            );
            this.Children.Add(new ContentPage
            {
                Title = "Loco",
                Content = new StackLayout
                {
                    Children = {new BoxView { Color = Color.Gray},
                               {new BoxView {Color = Color.Red} }
                    }
                }

            });
        }
    }
}