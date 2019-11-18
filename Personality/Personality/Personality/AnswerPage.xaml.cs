using System;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace Personality
{
    public partial class AnswerPage
    {
        static readonly HttpClient Client = new HttpClient();
        public AnswerPage()
        {
            InitializeComponent();

            var character = -1;
            if (Answers.Strength && Answers.Science && Answers.Gymnastics)
            {
                character = 1009282; //Dr. Strange
            }
            else if (Answers.Science && Answers.Strength)
            {
                character = 1009491; //Spiderman
            }
            else if (Answers.Science && Answers.Gymnastics)
            {
                character = 1009707; //Wasp
            }
            else if (Answers.Strength && Answers.Gymnastics)
            {
                character = 1009220; //Cpt America
            }
            else if (Answers.Science)
            {
                character = 1009368; //Iron Man
            }
            else if (Answers.Strength)
            {
                character = 1009351; //Hulk
            }
            else if (Answers.Gymnastics)
            {
                character = 1009189; //Black Widow
            }
            else
            {
                character = 1009348; //Happy Hogan
            }

            Answer.Text = GetCharacterDescription(character).Result;
        }

        public async Task<string> GetCharacterDescription(int i)
        {
            var desc = "";
            var response = await Client.GetAsync("http://gateway.marvel.com/v1/public/characters/" + i + "?apikey=1834be27cf3e4b0a615ed12e7b1fb0c1&hash=a8fce511fe293f924d562b7a2f8f32e1&ts=1");
            if (response.IsSuccessStatusCode)
            {
                desc = response.Content.ToString();
            }
            return desc;
        }
    }
}
