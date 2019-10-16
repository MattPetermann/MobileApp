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
            Answers.Fortunes = false;
            await Navigation.PushAsync(new AnswerPage());
        }

        public async void Right(object sender, EventArgs e)
        {
            Answers.Fortunes = true;
            await Navigation.PushAsync(new AnswerPage());
        }
    }
}
