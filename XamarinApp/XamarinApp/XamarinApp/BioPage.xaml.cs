using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BioPage : ContentPage
    {
        public BioPage(string person)
        {
            InitializeComponent();
            GetPersonDescription(person);
        }

        private void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            //Go to new page
            Application.Current.MainPage = new ListViewPage1();
        }

        private string GetPersonDescription(string person)
        {
            string description = "";
            Image bioImage = new Image();

            if (person == "Michael")
            {
                bioImage.Source = "michael.jpg";
                description = "I am a Redmond, WA-based programmer with a background in Classical Piano. In my spare time, I enjoy hiking, gaming and fitness. Having a background as a pianist has given me a lot of experience working under high stress environments while delivering a professional result, and I think that directly applies to the world of software development as well. As a Web Developer I look forward to building beautiful websites that will lead us into the future.";
            }

            if (person == "Na'ama")
            {
                bioImage.Source = "naama.jpg";
                description = "Coming from the world of online video and ad tech, my background is in managing client relations. I’ve always loved creating and building new things and coding is a fun new way to do it. My goal is to do work that is creative and interesting, and also has some positive impact on the world. I believe coding can do both. Outside of work I enjoy watching movies, cooking, gardening, and exploring the beautiful PNW";
            }

            if (person == "Lami")
            {
                bioImage.Source = "lami.jpg";
                description = "Hello, my name is Lami Beach. I got married and decided to change my name, and also take my wife's last name. Just to clear up any confusion. I'm originally from Arizona but moved to Seattle hoping to find new beginnings. I've written 8 screenplays and always dreamed of being a screenwriter. But it's time for a transition into something different. That and I'm still waiting on my big break. I hope to gain good foundations in this field and become proficient. If you want to know anything else feel free to ask.";
            }

            BioInfo.Children.Add(bioImage);

            NameLabel.Text = person;
            DescriptionLabel.Text = description;

            return description;
        }
    }
}