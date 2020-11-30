using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile x = new MusicFile("Pehli Nazar Mein", "Atif Aslam", 2007, 250);
            
            Iphone y = new Iphone("Iphone - 11");
            x.ShowInfo();
            y.AddMusic(x);
            y.ShowMusicInfo();
            MusicFile z = new MusicFile("Din gelo ","Habib",2008,200);
            y.AddMusic(z);
            y.ShowMusicInfo();

            MusicFile m = new MusicFile("Aadat", "Atif Aslam", 2004, 260);
            y.AddMusic(m);
            y.ShowMusicInfo();

            Redmi n = new Redmi("Redmi Note 8 pro");
            n.AddMusic(x);
            n.ShowMusicInfo();


        }
    }
}
