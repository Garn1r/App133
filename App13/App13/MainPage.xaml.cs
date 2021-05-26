using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App13
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //int a= Message_Enty.Text.Length;
            grid.Children.Add(stack_layout);
            stack_layout.Children.Add(new Label
            { 
                Padding= new Thickness(0,0,0,0),
                Text = Message_Enty.Text,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HeightRequest = 60,
                WidthRequest = Message_Enty.Text.Length*20,
                HorizontalOptions = LayoutOptions.End,
                BackgroundColor = Color.FromHex("ADB9FA")
            });
            /* var label = new Label
        {
            Text = Message_entry.Text,

        };
    Message_label.Text = Message_entry.Text;
    Message_entry.Text = "";
    Message_label.IsVisible = true;
    }
    }*/
        }
    }
}
