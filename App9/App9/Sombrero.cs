using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App9
{
    public class Sombrero : TabbedPage
    {
        public Sombrero()
        {
            this.Title = "Sombrero Seleccionador";
            this.Children.Add(new ContentPage
            {
                Title = "Casas",
                Content = new ListView
                {
                    ItemsSource = new List<string>
                    {
                        "Slytherin",
                        "Gryfindor",
                        "Ravenclaw,",
                        "Huffelpuff"
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