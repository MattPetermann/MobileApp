using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Personality
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenResult(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnswerPage((int)Math.Floor(AgeSlider.Value)));
        }
    }
}
