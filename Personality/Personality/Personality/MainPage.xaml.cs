﻿using System;

namespace Personality
{
    public partial class MainPage : IQuestionPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void Left(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }

        public async void Right(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
