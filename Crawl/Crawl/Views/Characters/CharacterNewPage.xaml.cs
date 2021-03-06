﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Crawl.Controllers;
using Crawl.Models;

namespace Crawl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterNewPage : ContentPage
    {
        public Character Data { get; set; }

        // Constructor for the page, will create a new black character that can tehn get updated
        public CharacterNewPage()
        {
            InitializeComponent();

            Data = new Character
            {
                Name = "Character name",
                Description = "This is an Character description.",
                Id = Guid.NewGuid().ToString(),
                Level = 1,
                ExperienceTotal = 100,
                ImageURI = ItemsController.DefaultImageURICharacter
            };

            BindingContext = this;
            //updates seleced item.
            ItemPicker.SelectedItem = Data.Item;
        }

        // Respond to the Save click
        // Send the add message to so it gets added...
        private async void Save_Clicked(object sender, EventArgs e)
        {
            // If the image in teh data box is empty, use the default one..
            if (string.IsNullOrEmpty(Data.ImageURI))
            {
                Data.ImageURI = ItemsController.DefaultImageURI;
            }

            MessagingCenter.Send(this, "AddData", Data);
            await Navigation.PopAsync();
        }

        // Cancel and go back a page in the navigation stack
        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        void LevelValue_OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            LevelValue.Text = String.Format("{0}", e.NewValue);
        }
    }
}