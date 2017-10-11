﻿using System;
using ModernEncryption.Presentation.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ModernEncryption.Presentation.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewGroupPage : ContentPage
    {

        public NewGroupPage ContactPageViewModel { get; set; }

        public NewGroupPage(NewGroupPage viewModel)
        {
            ContactPageViewModel = viewModel;

            InitializeComponent();

            viewModel.SetView(ContactPageViewModel);
            BindingContext = viewModel;
        }

    }
}
