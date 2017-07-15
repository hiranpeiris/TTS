using System;
using Xamarin.Forms;
using Plugin.TextToSpeech;

namespace TTS
{
    public partial class TTSPage : ContentPage
    {
        public TTSPage()
        {
            InitializeComponent();
        }

		private async void OnClick(object sender, EventArgs e)
		{
            var text = textEditor.Text.Trim();
            speakButton.IsEnabled = false;

            await CrossTextToSpeech.Current.Speak(text);

            speakButton.IsEnabled = true;
		}
    }
}
