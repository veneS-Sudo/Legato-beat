using System.Collections.ObjectModel;
using LiteDB;

namespace Legato_beat.Models
{
    public class Album
    {
        public const string CollectionName = "albums";

        private string _title;
        private int _yearAppearance;

        public Album()
        {
            Tracks = new ObservableCollection<Track>(); 
        }

        private int AlbumId { get; set; }
        public bool IsFavorite { get; set; }

        public string Title 
        { 
            get
            {
                if (string.IsNullOrEmpty(_title))
                    return "Unknown Title";
                return _title;
            }
            set => _title = value;
        }

        public string YearAppearance 
        {
            get
            {
                if (_yearAppearance == 0)
                    return "Unknown Year";
                return _yearAppearance.ToString();
            }
            set => _yearAppearance = int.Parse(value);
        }

        [BsonRef(Artist.CollectionName)]
        public Artist Artist { get; set; }

        [BsonRef(Track.CollectionName)]
        public ObservableCollection<Track> Tracks { get; set; }

    }
}
