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
            Answers.Gymnastics = false;
            await Navigation.PushAsync(new AnswerPage());
        }

        public async void Right(object sender, EventArgs e)
        {
            Answers.Gymnastics = true;
            await Navigation.PushAsync(new AnswerPage());
        }
    }
}
