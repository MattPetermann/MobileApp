using System;

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
            Answers.Strength = false;
            await Navigation.PushAsync(new SecondPage());
        }

        public async void Right(object sender, EventArgs e)
        {
            Answers.Strength = true;
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
