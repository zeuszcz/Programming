using System.Dynamic;

namespace Programming.Model
{
    public class Song
    {
        private string _name { get; set; }
        private int _duration { get; set; }
        private string _artist { get; set; }

        public Song()
        {
            
        }

        public Song(string name, int duration, string artist)
        {
            _name = name;
            _artist = artist;
            _duration = duration;
        }
    }
}