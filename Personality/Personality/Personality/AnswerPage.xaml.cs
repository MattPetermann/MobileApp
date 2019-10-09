namespace Personality
{
    public partial class AnswerPage
    {
        public AnswerPage(AnswerViewModel model)
        {
            InitializeComponent();

            if (model.Age < 14)
            {
                AnswerLabel.Text = $"{model.Name}, you are Ginny Weasley. " +
                                   "You've seen a very small portion of the world and " +
                                   "have lots to learn. ";
            }
            else if (model.Age < 18)
            {
                AnswerLabel.Text = $"{model.Name}, you are Harry Potter. " +
                                   "You've seen some of what the world has to offer but " +
                                   "have yet to experience some of life's greatest challenges.";
            }
            else if (model.Age < 50)
            {
                AnswerLabel.Text = $"{model.Name}, you are Professor Snape. " +
                                   "You've seen a lot of the world and are at an age where " +
                                   "you can influence younger crowds (for better or worse).";
            }
            else
            {
                AnswerLabel.Text = $"{model.Name}, you are Headmaster Dumbledore. " +
                                   "You have seen a lot of the world and have lots to offer " +
                                   "the younger generations.";
            }
        }
    }
}
