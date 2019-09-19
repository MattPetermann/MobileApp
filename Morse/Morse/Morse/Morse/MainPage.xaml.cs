using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Morse
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly List<string> _codes = new List<string> { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "" };

        private readonly List<char> _letters = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ' };

        public MainPage()
        {
            InitializeComponent();
        }

        public void Dot(object sender, EventArgs e) => Input.Text += ".";

        public void Dash(object sender, EventArgs e) => Input.Text += "-";

        public void Space(object sender, EventArgs e)
        {
            var idx = _codes.IndexOf(Input.Text);
            Output.Text += idx == -1 ? ' ' : _letters[idx];
            Input.Text = "";
        }
    }
}
