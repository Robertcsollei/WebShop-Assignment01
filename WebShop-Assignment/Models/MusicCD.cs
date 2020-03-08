using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop_Assignment.Models
{
    public class MusicCD : Product
    {

        public string Artist { get; set; }
        public string Label { set; get; }

        public short Released { set; get; }
        public TimeSpan PlayingTime { get; }
        public IList<track> Tracks { get; } = new List<track>();

        public void AddTrack(string trackName, string composer,TimeSpan length ) {
            Tracks.Add(new track(trackName, composer, length));
        
        }

        public MusicCD() { }
       

        public MusicCD(string artist, string title, decimal price, short released) : base(title, price)
        {
            Artist = artist;
            Released = released;
        
        }


    }
}
