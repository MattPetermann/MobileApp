using System;

namespace Personality
{
    public partial class ThirdPage : IQuestionPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        public async void Left(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnswerPage());
        }

        public async void Right(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnswerPage());
        }
    }
}
