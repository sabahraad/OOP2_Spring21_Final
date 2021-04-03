using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class Music
    {
        private string Title;

        public string title
        {
            get { return Title; }
            set { Title = value; }
        }

        private string Artist;

        public string artist
        {
            get { return Artist; }
            set { Artist = value; }
        }

        private int YearOfRelease;

        public int yearofrelease
        {
            get { return YearOfRelease; }
            set { YearOfRelease = value; }
        }

        private int DurationInSeconds;

        public int durationInSeconds
        {
            get { return DurationInSeconds; }
            set { DurationInSeconds = value; }
        }

        public Music()
        {

        }
        public Music(string title, string artist, int yearofrelease, int durationInSeconds)
        {
            Title = title;
            Artist = artist;
            YearOfRelease = yearofrelease;
            DurationInSeconds = durationInSeconds;
        }

        public void ChangeTitle(string Title)
        {
            this.Title = Title;

        }

        public void Show()
        {
            Console.WriteLine("Music Title:" + Title);
            Console.WriteLine("Music Artist:" + Artist);
            Console.WriteLine("Music year of Release:" + YearOfRelease);
            Console.WriteLine("Music Duration:" + DurationInSeconds);
            Console.WriteLine();
            Console.WriteLine("############################################");
            Console.WriteLine();
        }

    }
}
