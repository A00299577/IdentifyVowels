using System;
using Microsoft.Maui.Controls;

namespace IdentifyVowels
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void CheckVowel(object sender, EventArgs e)
        {
            string? input = letterEntry.Text?.Trim();

            if (!string.IsNullOrEmpty(input) && input.Length == 1 && char.IsLetter(input[0]))
            {
                char letter = char.ToLower(input[0]);

                if ("aeiou".Contains(letter))
                {
                    resultLabel.Text = "Vowel";
                }
                else
                {
                    resultLabel.Text = "Not a vowel";
                }
            }
            else
            {
                resultLabel.Text = "Please enter a valid letter.";
            }
        }
    }

}
