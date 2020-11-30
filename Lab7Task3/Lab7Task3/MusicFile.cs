using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task3
{
    class MusicFile
    {
        private string tittle;

        public string Tittle
        {
            get { return tittle; }
            set { tittle = value; }
        }
        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private int yearofrelease;

        public int YearOfRelease
        {
            get { return yearofrelease; }
            set { yearofrelease = value; }
        }
        private int duration ;

        public int Duration
        {
            get { return duration ; }
            set { duration  = value; }
        }
        public MusicFile()
        {

        }
        public MusicFile (string tittle , string artist , int yearofrelease , int duration)
        {
            this.tittle = tittle;
            this.artist = artist;
            this.yearofrelease = yearofrelease;
            this.duration = duration;
        }
        public void changetittle (string tittle)
        {

        }
        public void ShowInfo()
        {
            Console.WriteLine("Song Name :" + tittle);
            Console.WriteLine("Singer :" + artist);
            Console.WriteLine("Releasing Year :" + yearofrelease);
            Console.WriteLine("Duration :" +duration);
        }




    }
}
