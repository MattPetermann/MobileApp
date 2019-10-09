using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Personality
{
    public partial class AnswerPage
    {
        public AnswerPage(int age)
        {
            InitializeComponent();
            AgeLabel.Text = age + "";
        }
    }
}
