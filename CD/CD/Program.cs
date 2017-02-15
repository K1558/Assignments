using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();

            songs.Add(new Song { SongName = "The Phoenix", Leingth = 4.04 });
            songs.Add(new Song { SongName = "My Songs Know What You Did In The Dark", Leingth = 3.09 });
            songs.Add(new Song { SongName = "Alone Together", Leingth = 3.23 });
            songs.Add(new Song { SongName = "Where Did the Party Go", Leingth = 4.03 });
            songs.Add(new Song { SongName = "Just One Yesterday", Leingth = 4.04 });
            songs.Add(new Song { SongName = "The Mighty Fall", Leingth = 3.32 });
            songs.Add(new Song { SongName = "Miss Missing You", Leingth = 3.30 });
            songs.Add(new Song { SongName = "Death Valley", Leingth = 3.46 });
            songs.Add(new Song { SongName = "Young Volcanoes", Leingth = 3.24 });
            songs.Add(new Song { SongName = "Rat A Tat", Leingth = 4.02 });
            songs.Add(new Song { SongName = "Save Rock And Roll", Leingth = 4.41 });

            Cd cd = new Cd();
            cd.Name = "Save Rock and Roll";
            cd.Artist = "Fall Out Boy";

            Console.WriteLine("Name: " + cd.Name + " Artist: " + cd.Artist );
            Console.WriteLine("Songs: ");
            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }

            
        }

        
    }
}
