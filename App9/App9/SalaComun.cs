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
            var imagenHuf = new Image
            {
                Source = "hufflepuff.png"
            };
            this.Children.Add(new ContentPage
            {
                Title = "Casa",
                BackgroundImage = "slytherinmain.jpg",
                Content = new StackLayout
                {
                    
                    Spacing = 1,
                    Children = {
                        
                    }
                },
                
            }
            );
            this.Children.Add(new ContentPage
            {
                Title = "Tabla Casas",
                Content = new StackLayout
                {
                    Children = { imagenSly, imagenRav, imagenGry, imagenHuf },

                }
            });
        }
    }
}