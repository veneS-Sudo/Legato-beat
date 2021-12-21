using System;
using LiteDB;

namespace Legato_beat.Models
{
    public class Track
    {
        public const string CollectionName = "tracks";

        private string _subTitle;
        private TimeSpan _duration;

        public int TrackId { get; set; }
        public string TrackName { get; set; }
        public bool IsFavorite { get; set; }

        public string SubTitle 
        { 
            get
            {
                if (string.IsNullOrEmpty(_subTitle))
                    return "None";
                return _subTitle;
            }
            set => _subTitle = value;
        }

        public TimeSpan Duration
        {
            get
            {
                if (_duration <= TimeSpan.Zero)
                    return TimeSpan.Zero;
                return _duration;
            }
            set => _duration = value;
        }

        [BsonRef(Album.CollectionName)]
        public Album? Album { get; set; }

        public string Path { get; set; }
    }
}
