﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SlideMenuDemo.ViewModels;
using SlideMenuDemo.Views;

using Xamarin.Forms;

namespace SlideMenuDemo.Pages
{
    public partial class StartPage : ContentPage
    {
        static uint slideMenuSpeed = 200;
        int slideMenuOpenClosePosition;
        public MainViewModel _vm;

        public StartPage()
        {
            InitializeComponent();

            BindingContext = _vm = new MainViewModel();
            // ContentCarousel.ItemTemplate = new DataTemplate(typeof(MyFirstView));

            SubcribeToSlideUpMenuMessages(); // Needed to catch SlideUpMenu events such as open and close menu...

            MenuContentLayout.LowerChild(SlideUpMenu_Interactive); // hide menu used for interaction to the back of the display stack
            //NOTE: The menu for Interaction should not be set to invisible as this will cause problems registering for messaging
        }



        void SubcribeToSlideUpMenuMessages()
        {
            MessagingCenter.Subscribe<SlideUpMenuView>(this, "OpenCloseSlideUpMenu", async (sender) =>
           {
               await OpenCloseSlideUpMenuAsync();
           });

            MessagingCenter.Subscribe<SlideUpMenuView>(this, "CloseSlideUpMenu", async (sender) =>
            {
                await CloseSlideUpMenuAsync();
            });

            MessagingCenter.Subscribe<SlideUpMenuView>(this, "LeftClicked", (sender) =>
            {
                _vm.Position = 0;
            });
            MessagingCenter.Subscribe<SlideUpMenuView>(this, "RightClicked", (sender) =>
            {
                _vm.Position = 1;
            });
        }

        async Task OpenCloseSlideUpMenuAsync()
        {
            slideMenuOpenClosePosition++;

            if (slideMenuOpenClosePosition % 2 == 0) // Close SlideUp Menu
            {
                await CloseSlideUpMenuAsync();

            }
            else // Open SlideUp Menu
            {
                await OpenSlideUpMenuAsync();
            }
        }

        async Task CloseSlideUpMenuAsync()
        {
            // Hide menu
            SlideUpMenu_Animated.IsVisible = true; 
            MenuContentLayout.LowerChild(SlideUpMenu_Interactive);
            await SlideUpMenu_Animated.TranslateTo(0, 0, slideMenuSpeed, Easing.CubicInOut);

            // content overlay
            await ContentOverlay.FadeTo(0, 100, Easing.CubicOut);
            ContentOverlay.IsVisible = false;


            slideMenuOpenClosePosition = 0; // reset counter to menu closed
        }

        async Task OpenSlideUpMenuAsync()
        {
            // content overlay
            ContentOverlay.IsVisible = true;
            await ContentOverlay.FadeTo(0.9, 20, Easing.CubicIn);

            // Show menu
            await SlideUpMenu_Animated.TranslateTo(0, -200, slideMenuSpeed, Easing.CubicInOut);
			MenuContentLayout.RaiseChild(SlideUpMenu_Interactive);
            SlideUpMenu_Animated.IsVisible = false; 

            slideMenuOpenClosePosition = 1; // Set flag to menu Open
        }

        async void ContentOverlayTabbed(object sender, EventArgs args)
        {
            await OpenCloseSlideUpMenuAsync();
        }
    }
}