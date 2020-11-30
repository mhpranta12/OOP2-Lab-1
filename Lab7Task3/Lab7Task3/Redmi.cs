using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task3
{
    class Redmi : MusicPlayerInterface
    {
        public string n;
        private int mscount = 0;
        MusicFile[] listofmusic;

        public Redmi()
        {
        }
        public Redmi(string n)
        {
            this.n = n;
            listofmusic = new MusicFile[500];

        }
        public void AddMusic(MusicFile x)
        {

            listofmusic[mscount++] = x;
            Console.WriteLine("Added!");

        }
        public void ShowMusicInfo()
        {
            Console.WriteLine(this.n + " has following music :");
            int j = 1;
            for (int i = 1; i < mscount; i++)
            {
                Console.WriteLine(j + ".");
                listofmusic[i].ShowInfo();
                j++;
            }


        }
        public void Switch(bool x)
        {
            if (x.Equals("on"))
            {
                Console.WriteLine("The Music Player is now ON !!");
            }
            else
                Console.WriteLine("The Music Player is now OFF");
        }
        public void play(bool on)
        {
            for (int i = 0; i < mscount; i++)
            {

            }
        }
        public void setVolume(int loudness)
        {

        }
        public void playNext()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Playing :");
                listofmusic[i].ShowInfo();
            }
        }
        public void playPrevious()
        {

        }

    }
}
