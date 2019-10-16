using System;

namespace Personality
{
    public partial class AnswerPage
    {
        public AnswerPage()
        {
            InitializeComponent();

            var character = "";
            if (Answers.Potions && Answers.Fortunes && Answers.Spells)
            {
                character = "Harry";
            }
            else if (Answers.Potions && Answers.Fortunes)
            {
                character = "Luna";
            }
            else if (Answers.Potions && Answers.Spells)
            {
                character = "Hermione";
            }
            else if (Answers.Fortunes && Answers.Spells)
            {
                character = "Dumbledore";
            }
            else if (Answers.Potions)
            {
                character = "Snape";
            }
            else if (Answers.Fortunes)
            {
                character = "Trelawney";
            }
            else if (Answers.Spells)
            {
                character = "Lockhart";
            }
            else
            {
                character = "Dudley";
            }

            Answer.Text = character;
        }
    }
}
