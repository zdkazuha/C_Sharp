using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_homework
{
    class Song
    {
        private string songTitle;
        private int songLength;
        private string songStyle;
        public string SongTitle { get=> songTitle; set => songTitle = value ?? "NoName"; }
        public int SongLength { get=> songLength; set=> songLength = value > 0 ? value : 0; }
        public string SongStyle { get=> songStyle; set => songStyle = value ?? "NoStyle"; }

        public Song()
            :this("NoName",0,"NoStyle") {}

        public Song(string songTitle,int songLength,string songstyle)
        {
            SongTitle = songTitle;
            SongLength = songLength;
            SongStyle = songstyle;
        }

        public override string ToString()
        {
            return $"Song title  :: {songTitle}\nSong length :: {songLength}\nSong Style  :: {songStyle}";
        }

        public void Print()
        {
            Console.WriteLine($"Song title  :: {songTitle}\nSong length :: {songLength}\nSong Style  :: {songStyle}");
        }

        public void Input()
        {
            Console.WriteLine("Введіть назву пісні      :: ");
            SongTitle = Console.ReadLine()!;
            Console.WriteLine("Введіть тривалість пісні :: ");
            SongLength = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введіть стиль пісні      :: ");
            SongStyle = Console.ReadLine()!;
            Console.WriteLine("\nПісню успішно додано!");
        }
    }



    class MusicAlbum
    {
        public List<Song> listSong = new List<Song>();
        private string nameAlbum;
        private string artistName;
        private int releaseYear;
        private int duration;
        private string recordingStudio;

        public string NameAlbum { get => nameAlbum; set => nameAlbum = value ?? "NoName"; }
        public string ArtistName { get => artistName; set => artistName = value ?? "NoName"; }
        public int ReleaseYear { get => releaseYear; set => releaseYear = value >= 0 ? value : 0; }
        public int Duration { get=> duration; set=> duration = value >= 0 ? value : 0; }
        public string RecordingStudio { get => recordingStudio; set => recordingStudio = value ?? "NoName"; }

        public MusicAlbum()
            :this(new Song(),"NoName","NoName",2000,0,"NoName") {}
        public MusicAlbum(Song song,string nameAlbum, string artistName, int year, int duration, string studio)
        {
            listSong.Add(song);
            NameAlbum = nameAlbum;
            ArtistName = artistName;
            ReleaseYear = year;
            Duration = duration;
            RecordingStudio = studio;
        }

        public MusicAlbum(List<Song> listsong, string nameAlbum, string artistName, int year, int duration, string studio)
        {
            listSong = listsong;
            NameAlbum = nameAlbum;
            ArtistName = artistName;
            ReleaseYear = year;
            Duration = duration;
            RecordingStudio = studio;
        }


        public override string ToString()
        {
            for (int i = 0;i < listSong.Count();i++)
            {
                Console.WriteLine($"Song #{i + 1}");
                listSong[i].Print();
            }
            return ($"Name album       :: {nameAlbum}\n" +
                    $"Artist name      :: {artistName}\n" +
                    $"Year of release  :: {releaseYear}\n" +
                    $"Duration         :: {duration} minute\n" +
                    $"Recording Studio :: {recordingStudio}");
        }

        public void Print()
        {
            for (int i = 0; i < listSong.Count(); i++)
            {
                Console.WriteLine($"Song #{i + 1}");
                listSong[i].Print();
            }
            Console.WriteLine($"Name album       :: {nameAlbum}\n" +
                              $"Artist name      :: {artistName}\n" +
                              $"Year of release  :: {releaseYear}\n" +
                              $"Duration         :: {duration} minute\n" +
                              $"Recording Studio :: {recordingStudio}");
        }

        public void Input()
        {
            InputSong();

            Console.Write("Ведіть назву альбома            :: ");
            NameAlbum = Console.ReadLine()!;
            Console.Write("Ведіть ім'я артисту             :: ");
            ArtistName = Console.ReadLine()!; 
            Console.Write("Ведіть рік випуску              :: ");
            ReleaseYear = int.Parse(Console.ReadLine()!); 
            Console.Write("Ведіть тривалісь в минутах      :: ");
            Duration = int.Parse(Console.ReadLine()!); 
            Console.Write("Ведіть назву студії звукозапису :: ");
            RecordingStudio = Console.ReadLine()!;
            Console.WriteLine("\nАльбом успішно додано!");
        }

        public void InputSong()
        {
            Song song = new Song();
            song.Input();
            listSong.Add(song);
            Console.WriteLine("Пісню успішно додано до альбому");
        }



    }
}
