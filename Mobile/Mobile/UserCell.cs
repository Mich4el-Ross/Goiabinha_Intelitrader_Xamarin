using ImageCircle.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mobile
{
    public class UserCell : ViewCell
    {
        public UserCell()
        {

            var UserId = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 13,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#FE7B1D"),
                Margin = new Thickness(0, 15, 5, 0),
                
            };
            UserId.SetBinding(Label.TextProperty, new Binding("Id", stringFormat: "ID = {0}"));

            var FirstName = new Label
            {
                FontSize = 22,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Start,
                Margin = new Thickness(0,5,0,0),
                TextColor = Color.White
            };
            FirstName.SetBinding(Label.TextProperty, new Binding("FirstName", stringFormat: "Name: {0}"));

            var SurName = new Label
            {
                FontSize = 22,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Start,
                Margin = new Thickness(0, 5, 0, 0),
                TextColor = Color.White
            };
            SurName.SetBinding(Label.TextProperty, new Binding("SurName", stringFormat: "{0}"));

           

            var Age = new Label
            {
                FontSize = 22,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start,
                TextColor = Color.White,
                Margin = new Thickness(0, 5, 0, 0),
            };
            Age.SetBinding(Label.TextProperty, new Binding("Age", stringFormat: "Age: {0} years old"));


            var CreationDate = new Label
            {
                FontSize = 16,
                FontAttributes = FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                Margin = new Thickness(0, 10, 0, 25),
                TextColor = Color.White,
            };
            CreationDate.SetBinding(Label.TextProperty, new Binding("CreationDate", stringFormat: "User created on {0}"));


            var Image = new CircleImage
            {
                BorderColor = Color.White,
                BorderThickness = 2,
                HeightRequest = 60,
                WidthRequest = 60,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                Source = "User50"
            };
            Image.SetBinding(Label.TextProperty, new Binding("Image"));

            var line0 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    UserId
                },
            };

            var line1 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {
                     FirstName,SurName
                },
            };
            var line2 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {
                     Age
                },
            };

            var line3 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {
                     CreationDate
                },
            };

            View = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = {
                    line0,line1, line2, line3
                },
            };


        }
    }
}

