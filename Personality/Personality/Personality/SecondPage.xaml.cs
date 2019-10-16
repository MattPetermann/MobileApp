using System;

namespace Personality
{
    public partial class SecondPage : IQuestionPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        public async void Left(object sender, EventArgs e)
        {
            Answers.Spells = false;
            await Navigation.PushAsync(new ThirdPage());
        }

        public async void Right(object sender, EventArgs e)
        {
            Answers.Spells = true;
            await Navigation.PushAsync(new ThirdPage());
        }
    }
}
